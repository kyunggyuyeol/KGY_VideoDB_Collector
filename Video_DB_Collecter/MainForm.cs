using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using MediaInfo;


namespace Video_DB_Collecter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //작업할 데이터 list
        List<DataClass> dataList;
        public int dataNo = 0;
        List<reWriteData> reWriteList = new List<reWriteData>();


        //추천 태그 정렬 list
        List<Tag> tagList;

        //최종태깅용 전역변수
        List<MasterTag> masterTag;
        List<string> MasterTagNo;
        public int MasterNO = 0;

        //로컬모드확인
        public bool localmode = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            //미디어플레이어 루프 설정
            MediaPlayer.settings.setMode("loop", true);
            tabControl.SelectedTab = tabControl.TabPages[3];
            //test
            //MediaPlayer.URL = "http://192.168.0.201/videodb/drama/drama_0100/drama_0100.mp4";
        }


        public void translateGoogle(string korString)
        {
            if (korString == "")
            {
                MessageBox.Show("input convert Message");
                return;
            }

            WebRequest req = WebRequest.Create("https://translate.google.com/?hl=en&ie=UTF8&text=" + korString + "&langpair=ko");
            HttpWebRequest httpreq = (HttpWebRequest)req;
            httpreq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            httpreq.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36";
            httpreq.Referer = "https://www.google.co.kr/";
            httpreq.ContentType = "text/html; charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)httpreq.GetResponse();
            Stream stReadData = response.GetResponseStream();
            StreamReader srReadData = new StreamReader(stReadData, Encoding.UTF8);

            // 응답 Stream -> 응답 String 변환
            string strResult = srReadData.ReadToEnd();

            int s = strResult.IndexOf("span title=");
            if (s == -1)
            {
                txt_transe.Text = "번역 문제가 발생하였습니다.";
                return;
            }
            string start = strResult.Substring(s);
            int end = start.IndexOf("</span>");
            string value = start.Substring(0, end);
            string[] valueArr = value.Split('>');
            if (valueArr.Length == 2)
            {
                //textBox1.Text = valueArr[1];
                txt_transe.Text = valueArr[1];
            }
        }

        public bool dbContest()
        {
            MySqlDataAdapter adpt = new MySqlDataAdapter("select version()", DbInfo.conn);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            string check = string.Empty;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                check = item[0].ToString();
            }

            if (check != string.Empty)
                return true;
            else
                return false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                rb_google.Checked = true;
                txt_transe.Text = "";
                translateGoogle(txt_userInput.Text);
            }
            else if (e.KeyCode == Keys.F4)
            {
                rb_Naver.Checked = true;
                txt_transe.Text = "";
                translateNaver(txt_userInput.Text);
            }
        }

        public void translateNaver(string transString)
        {
            if (txt_clientScret.Text == string.Empty || txt_clinetID.Text == string.Empty)
            {
                MessageBox.Show("plz checked apikey");
                return;
            }

            string url = "https://openapi.naver.com/v1/language/translate";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", txt_clinetID.Text);
            request.Headers.Add("X-Naver-Client-Secret", txt_clientScret.Text);
            request.Method = "POST";
            string query = transString;
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=ko&target=en&text=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();
            Console.WriteLine(text);

            JObject jo = JObject.Parse(text);
            string value = jo["message"]["result"]["translatedText"].ToString();
            txt_transe.Text = value;
        }

        private void btn_conntest_Click(object sender, EventArgs e)
        {
            if (txt_clientScret.Text == string.Empty || txt_clinetID.Text == string.Empty || txt_filePath.Text == string.Empty)
            {
                MessageBox.Show("checked apikey");
                return;
            }
            else if (txt_server.Text == string.Empty || txt_user.Text == string.Empty || txt_pw.Text == string.Empty)
            {
                MessageBox.Show("Check db info check");
                return;
            }

            //모드 설정시 문제 발생 없도록 하기위해 ... 버튼 사용중지 시킴
            btn_SetPath.Enabled = false;

            var ipaddr = Dns.GetHostAddresses(txt_server.Text);

            DbInfo.server = ipaddr[0].ToString();
            DbInfo.id = txt_user.Text;
            DbInfo.pw = txt_pw.Text;
            DbInfo.port = txt_port.Text;

            if (!dbContest())
            {
                MessageBox.Show("DB not connection");
                return;
            }
            else
            {
                MessageBox.Show("DB connection OK");
            }


            cmb_cat.Items.Clear();
            cmb_MasterCat.Items.Clear();


            //카테고리 불러와 세팅
            DataSet ds = selectForDataSet("select distinct Cat_Type from videomaster;");
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                cmb_cat.Items.Add(item[0].ToString());
                cmb_MasterCat.Items.Add(item[0].ToString());
            }
        }

        private void btn_SetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();

            if (fb.ShowDialog() == DialogResult.OK)
            {
                txt_filePath.Text = fb.SelectedPath;
                localmode = true;
            }
        }

        private void btn_userSearch_Click(object sender, EventArgs e)
        {
            clearData();

            if (txt_filePath.Text == string.Empty)
            {
                MessageBox.Show("Checked filepath");
                return;
            }

            //카테고리 선택 하여 쿼리 작성
            if (cmb_cat.Text != "")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT distinct FileLV_1, FileLV_2, FileLV_3 from videousertag \n");
                sb.Append("WHERE Message is null and Cat_Type = '" + cmb_cat.Text + "'; ");

                DataSet ds = selectForDataSet(sb.ToString());
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    dataList.Add(new DataClass(false, cmb_cat.Text, item[0].ToString(), item[1].ToString(), item[2].ToString(), txt_filePath.Text));

                    list_userTag.Items.Add(item[2].ToString());
                }

                if (dataList.Count >= 1)
                {
                    //사용자 태깅 검색할때 로컬모드일 경우 파일이 로컬에 존재하는지 체크해야함
                    if (localmode == true)
                    {
                        if (File.Exists(dataList[dataNo].FilePath))
                            MediaPlayer.URL = dataList[dataNo].FilePath;
                        else
                        {
                            MessageBox.Show("Checked local path");
                            MediaPlayer.URL = "";
                            return;
                        }
                    }
                    else
                    {
                        MediaPlayer.URL = dataList[dataNo].FilePath;
                    }

                    string[] splitArr = dataList[dataNo].FileLV_1.Split('_');
                    txt_fileSearch.Text = splitArr[1];
                    list_userTag.SelectedIndex = 0;
                }
                else if (dataList.Count == 0)
                {
                    list_userTag.Items.Clear();
                    MediaPlayer.URL = "";
                    MessageBox.Show("input data end");
                    return;
                }
            }
        }


        public DataSet selectForDataSet(string query)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(query, DbInfo.conn);
            try
            {
                adpt.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.Message + "\n" + query);
            }
            return ds;
        }

        private void btn_msgSave_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                MessageBox.Show("input data end");
                return;
            }

            //입력이 하나라도 빠졌을 경우
            if (txt_msg1.Text == "" || txt_msg2.Text == "" || txt_msg3.Text == "" || cmb_cat.Text == "")
            {
                MessageBox.Show("plz check input message");
                return;
            }

            //사용자 테이블 업데이트
            UserUpdate();

            //4번쨰가 저장 된다면 마스터 태그 테이블의 USE_YN 플래그를 Y로 변경한다.
            string test = dataList[dataNo].FilePath;
            string fileName = Path.GetFileNameWithoutExtension(test);
            string[] NameArr = fileName.Split('_');
            if (NameArr.Length == 3)
            {
                string value = NameArr[2].Replace("clip", "");

                if (value == "04")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE videomastertag SET Use_YN = 'Y' \n");
                    sb.Append("WHERE Cat_Type = '" + dataList[dataNo].Cat_Type + "' and ");
                    sb.Append("FileLV_1 = '" + dataList[dataNo].FileLV_1 + "';");
                    queryExcute(sb.ToString());
                }
            }

            MessageBox.Show("Save Ok!");

            if ((dataNo + 1) != dataList.Count)
            {
                dataNo++;

                //메세지를 저장할때 로컬모드 체크
                if(localmode == true)
                {
                    if(File.Exists(dataList[dataNo].FilePath))
                    {
                        MediaPlayer.URL = dataList[dataNo].FilePath;
                    }
                    else
                    {
                        MessageBox.Show("Checked localpath");
                        MediaPlayer.URL = "";
                        return;
                    }
                }

                MediaPlayer.URL = dataList[dataNo].FilePath;
                string[] splitArr = dataList[dataNo].FileLV_1.Split('_');
                txt_fileSearch.Text = splitArr[1];
                list_userTag.SelectedIndex = dataNo;

                //수정모드 일경우 저장 된 값을 불러옴
                if (dataList[dataNo].reWrite == true)
                {
                    List<reWriteData> reWriteDataInput = reWriteList.Where(x => x.FileLV_3 == dataList[dataNo].FileLV_3).ToList();
                    if (reWriteDataInput.Count == 3)
                    {
                        txt_msg1.Text = reWriteDataInput[0].Message;
                        txt_msg2.Text = reWriteDataInput[1].Message;
                        txt_msg3.Text = reWriteDataInput[2].Message;
                    }
                }

            }
            else if ((dataNo + 1) == dataList.Count)
            {
                MessageBox.Show("Input end.");
                MediaPlayer.URL = "";
                clearTxtMessage();
            }

            if (dataList[dataNo].reWrite != true)
            {
                clearTxtMessage();
            }
            else
            {
                txt_msg1.Focus();
            }
        }

        public void clearTxtMessage()
        {
            txt_msg1.Text = "";
            txt_msg2.Text = "";
            txt_msg3.Text = "";
            txt_msg1.Focus();
        }

        public void UserUpdate()
        {
            string[] UserArr = new string[] { "User1", "User2", "User3" };

            //User1 Update
            string query = createUpdateUserInput(txt_msg1.Text, UserArr[0]);
            queryExcute(query);

            //User2 Update
            query = createUpdateUserInput(txt_msg2.Text, UserArr[1]);
            queryExcute(query);

            //User3 Update
            query = createUpdateUserInput(txt_msg3.Text, UserArr[2]);
            queryExcute(query);
        }

        public bool queryExcute(string query)
        {
            bool update = true;
            DbInfo.conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, DbInfo.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                update = false;
                MessageBox.Show(ex.Message + "\n" + query);
            }
            finally
            {
                DbInfo.conn.Close();
            }
            return update;
        }

        public string createUpdateUserInput(string message, string UserNo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE videousertag SET Message = '" + MySqlHelper.EscapeString(message) + "'\n");
            sb.Append("WHERE Cat_Type= '" + dataList[dataNo].Cat_Type + "' and ");
            sb.Append("FileLV_1 = '" + dataList[dataNo].FileLV_1 + "' and ");
            sb.Append("FileLV_2 = '" + dataList[dataNo].FileLV_2 + "' and ");
            sb.Append("FileLV_3 = '" + dataList[dataNo].FileLV_3 + "' and ");
            sb.Append("InputUser = '" + UserNo + "';");

            return sb.ToString();
        }

        public string createUpdateMasterInput(string message, string tag)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE videomastertag SET Messgae = '" + MySqlHelper.EscapeString(message) + "', Tag = '" + MySqlHelper.EscapeString(tag) + "'\n");
            sb.Append("WHERE Cat_Type = '" + dataList[dataNo].Cat_Type + "' and ");
            sb.Append("FileLV_1 = '" + dataList[dataNo].FileLV_1 + "';");

            return sb.ToString();
        }

        public void checkTag(string[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < tagList.Count; j++)
                {
                    if (Arr[i] == tagList[j].tagName)
                    {
                        tagList[j].count++;
                        check = false;
                    }
                }

                if (check == true)
                {
                    tagList.Add(new Tag(1, Arr[i]));
                }
            }
        }

        private void btn_MasterSave_Click(object sender, EventArgs e)
        {
            if (MasterTagNo.Count == 0)
            {
                MessageBox.Show("Input end");
                return;
            }
            if (txt_MasterMessage.Text == string.Empty || txt_Tag.Text == string.Empty)
            {
                MessageBox.Show("plz Checked message and tag");
                return;
            }

            string fileLV_1 = Path.GetFileNameWithoutExtension(MediaPlayer.URL);

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE videomastertag SET Message = '" + MySqlHelper.EscapeString(txt_MasterMessage.Text) + "', Tag = '" + MySqlHelper.EscapeString(txt_Tag.Text) + "'");
            sb.Append("WHERE Cat_Type='" + cmb_MasterCat.SelectedItem.ToString() + "' and FileLV_1 = '" + fileLV_1 + "';");

            if (queryExcute(sb.ToString()))
            {
                ClearMasterTextBox();

                if ((MasterNO + 1) != MasterTagNo.Count)
                {
                    MasterNO++;
                    //다음작업 진행
                    string getIndex = MasterTagNo[MasterNO].ToString();
                    //재생할 파일 이름 불러옴
                    var player = masterTag.Where(x => x.mainClip == getIndex).ToList();
                    
                    //마스터 세이브 모드 중 로컬모드 사용일때 파일이 존재하는지 확인해야 한다.
                    if(localmode == true)
                    {
                        if(File.Exists(player[0].FilePath))
                        {
                            MediaPlayer.URL = player[0].FilePath;
                        }
                        else
                        {
                            MessageBox.Show("check local filepath");
                            MediaPlayer.URL = "";
                            return;
                        }
                    }
                    MediaPlayer.URL = player[0].FilePath;
                    //클립명 변경

                    tagList = new List<Tag>();
                    tagList.Clear();

                    //01 02 03 04 텍스트 값 줘야함
                    masterTextBoxSetting(getIndex, "01", txt_Clip01);
                    masterTextBoxSetting(getIndex, "02", txt_Clip02);
                    masterTextBoxSetting(getIndex, "03", txt_Clip03);
                    masterTextBoxSetting(getIndex, "04", txt_Clip04);

                    list_Tag.Items.Clear();
                    List<Tag> orderbyList = tagList.OfType<Tag>().OrderByDescending(x => x.count).ToList();
                    for (int i = 0; i < orderbyList.Count; i++)
                    {
                        list_Tag.Items.Add(orderbyList[i].tagName);
                    }

                }
                else
                {
                    MessageBox.Show("Master input end");
                    MediaPlayer.URL = "";
                    ClearMasterTextBox();
                    return;
                }
            }
        }

        /// <summary>
        /// 마스터태그 관련 자리를 클리어 한다.
        /// </summary>
        public void ClearMasterTextBox()
        {
            txt_Clip01.Text = "";
            txt_Clip02.Text = "";
            txt_Clip03.Text = "";
            txt_Clip04.Text = "";

            txt_MasterMessage.Text = "";
            txt_Tag.Text = "";
            list_Tag.Items.Clear();
        }

        /// <summary>
        /// mastertag 정보 select 문법
        /// </summary>
        public void masterTagdataLoad()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select   a.FileLV_1, b.FileLV_3, ");
            sb.Append("b.Message ");
            sb.Append("from     videodb.videomastertag A, ");
            sb.Append("videodb.videousertag B ");
            sb.Append("where    A.USE_YN     = 'Y' ");
            sb.Append("and A.Message is null ");
            sb.Append("and A.Tag is null ");
            sb.Append("and      A.Cat_Type = '" + cmb_MasterCat.SelectedItem.ToString() + "' ");
            sb.Append("and      A.Cat_Type = B.Cat_Type ");
            sb.Append("and      A.FileLV_1 = B.FileLV_1 ");
            sb.Append("order by b.FileLV_3, b.InputUser");

            DataSet ds = selectForDataSet(sb.ToString());
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string filepath = Path.Combine(txt_filePath.Text, cmb_MasterCat.SelectedItem.ToString(), item[0].ToString(), item[0].ToString() + ".mp4");
                string[] clipArr = item[1].ToString().Split('_');
                masterTag.Add(new MasterTag(clipArr[2].Replace("clip", ""), item[2].ToString(), filepath, item[0].ToString()));

                if (MasterTagNo.Count == 0)
                {
                    MasterTagNo.Add(item[0].ToString());
                }
                else
                {
                    bool check = MasterTagNo.Contains(item[0]);
                    if (check == false)
                    {
                        MasterTagNo.Add(item[0].ToString());
                    }
                }
            }
        }

        public void masterTagdataLoadreWrite(string fileLV_1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select   a.FileLV_1, b.FileLV_3, ");
            sb.Append("b.Message ");
            sb.Append("from     videodb.videomastertag A, ");
            sb.Append("videodb.videousertag B ");
            sb.Append("where    A.USE_YN     = 'Y' ");
            sb.Append("and A.Message is not null ");
            sb.Append("and A.Tag is not null ");
            sb.Append("and      A.Cat_Type = '" + cmb_MasterCat.SelectedItem.ToString() + "' ");
            sb.Append("and      A.Cat_Type = B.Cat_Type ");
            sb.Append("and      A.FileLV_1 = B.FileLV_1 ");
            sb.Append("and      A.FileLV_1 = '" + fileLV_1 + "' ");
            sb.Append("order by b.FileLV_3, b.InputUser");

            Console.WriteLine(sb.ToString());

            DataSet ds = selectForDataSet(sb.ToString());
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string filepath = Path.Combine(txt_filePath.Text, cmb_MasterCat.SelectedItem.ToString(), item[0].ToString(), item[0].ToString() + ".mp4");
                string[] clipArr = item[1].ToString().Split('_');
                masterTag.Add(new MasterTag(clipArr[2].Replace("clip", ""), item[2].ToString(), filepath, item[0].ToString()));

                //list의 카운터가 0이면
                if (MasterTagNo.Count == 0)
                {
                    MasterTagNo.Add(item[0].ToString());
                }
                else
                {
                    bool check = MasterTagNo.Contains(item[0]);
                    if (check == false)
                    {
                        MasterTagNo.Add(item[0].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// 모든 list, 변수등을 초기화 한다.
        /// </summary>
        public void clearData()
        {
            MediaPlayer.URL = "";
            dataList = new List<DataClass>();
            dataList.Clear();
            dataNo = 0;
            list_userTag.Items.Clear();
            reWriteList.Clear();

            ClearMasterTextBox();
            MasterNO = 0;
            masterTag = new List<MasterTag>();
            MasterTagNo = new List<string>();
        }

        private void btn_MasterSelect_Click(object sender, EventArgs e)
        {
            clearData();

            if (cmb_MasterCat.SelectedItem == null)
            {
                MessageBox.Show("checked category");
                return;
            }

            masterTagdataLoad();

            //메인클립 영상 띄우고 클립들에 텍스트 넣어주고 추천 태그 뽑아와야함

            if (MasterTagNo.Count > MasterNO)
            {

                string selectName = MasterTagNo[MasterNO].ToString();
                txt_masterREWrite.Text = selectName.Split('_')[1];

                //재생할 파일 이름 불러옴
                var player = masterTag.Where(x => x.mainClip == selectName).ToList();

                string playeFileName = player[0].FilePath;
                
                //마스터 검색시 로컬모드일경우 파일이 있는지 확인해야한다.
                if(localmode == true)
                {
                    if(File.Exists(playeFileName))
                    {
                        MediaPlayer.URL = playeFileName;
                    }
                    else
                    {
                        MessageBox.Show("checked local filePath");
                        MediaPlayer.URL = "";
                        return;
                    }
                }

                MediaPlayer.URL = playeFileName;

                tagList = new List<Tag>();
                tagList.Clear();

                //01 02 03 04 텍스트 값 줘야함
                masterTextBoxSetting(selectName, "01", txt_Clip01);
                masterTextBoxSetting(selectName, "02", txt_Clip02);
                masterTextBoxSetting(selectName, "03", txt_Clip03);
                masterTextBoxSetting(selectName, "04", txt_Clip04);

                list_Tag.Items.Clear();
                List<Tag> orderbyList = tagList.OfType<Tag>().OrderByDescending(x => x.count).ToList();
                for (int i = 0; i < orderbyList.Count; i++)
                {
                    list_Tag.Items.Add(orderbyList[i].count + " : " + orderbyList[i].tagName);
                }
            }
        }

        public void masterTextBoxSetting(string selectName, string clipName, TextBox addtextbox)
        {
            addtextbox.Text = "";

            List<MasterTag> selectList = masterTag.Where(x => x.mainClip == selectName && x.clipName == clipName).ToList();
            for (int i = 0; i < selectList.Count; i++)
            {
                addtextbox.Text += selectList[i].Message + "\r\n";
                checkTag(selectList[i].Message.Split(' '));
            }

        }

        private void list_Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Tag.Text == "")
            {
                string[] arr = list_Tag.SelectedItem.ToString().Split(':');
                if (arr.Length == 2)
                {
                    txt_Tag.Text += arr[1].Trim();
                }
            }

            else
            {
                string[] arr = list_Tag.SelectedItem.ToString().Split(':');
                if (arr.Length == 2)
                {
                    txt_Tag.Text += "," + arr[1].Trim();
                }
            }
        }

        private void txt_fileSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clearTxtMessage();
                clearData();

                if (cmb_cat.Text != "")
                {
                    string whereFileLV_1 = cmb_cat.Text + "_" + txt_fileSearch.Text;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT distinct FileLV_1, FileLV_2, FileLV_3  from videousertag \n");
                    sb.Append("WHERE FileLV_1 = '" + whereFileLV_1 + "' and Cat_Type = '" + cmb_cat.Text + "'; ");

                    DataSet ds = selectForDataSet(sb.ToString());
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        dataList.Add(new DataClass(true, cmb_cat.Text, item[0].ToString(), item[1].ToString(), item[2].ToString(), txt_filePath.Text));
                        list_userTag.Items.Add(item[2].ToString());
                    }

                    sb.Clear();
                    ds.Clear();

                    sb.Append("select A.FileLV_3, A.Message from videousertag A where A.FileLV_1 = '" + whereFileLV_1 + "' order by A.FileLV_3;");
                    ds = selectForDataSet(sb.ToString());

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        reWriteList.Add(new reWriteData(item[0].ToString(), item[1].ToString()));
                    }

                    if (dataList.Count >= 1)
                    {
                        MediaPlayer.URL = dataList[dataNo].FilePath;
                        string[] splitArr = dataList[dataNo].FileLV_1.Split('_');
                        txt_fileSearch.Text = splitArr[1];
                        list_userTag.SelectedIndex = dataNo;

                        //수정모드 일경우 저장 된 값을 불러옴
                        if (dataList[dataNo].reWrite == true)
                        {
                            List<reWriteData> reWriteDataInput = reWriteList.Where(x => x.FileLV_3 == dataList[dataNo].FileLV_3).ToList();
                            if (reWriteDataInput.Count == 3)
                            {
                                txt_msg1.Text = reWriteDataInput[0].Message;
                                txt_msg2.Text = reWriteDataInput[1].Message;
                                txt_msg3.Text = reWriteDataInput[2].Message;
                            }
                        }

                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clearData();

                if (cmb_MasterCat.SelectedItem == null)
                {
                    MessageBox.Show("checked category");
                    return;
                }
                string filefb = cmb_MasterCat.Items[cmb_MasterCat.SelectedIndex].ToString() + "_" + txt_masterREWrite.Text;

                masterTagdataLoadreWrite(filefb);

                //메인클립 영상 띄우고 클립들에 텍스트 넣어주고 추천 태그 뽑아와야함

                if (MasterTagNo.Count > MasterNO)
                {

                    string selectName = MasterTagNo[MasterNO].ToString();

                    //재생할 파일 이름 불러옴
                    var player = masterTag.Where(x => x.mainClip == selectName).ToList();

                    string playeFileName = player[0].FilePath;
                    MediaPlayer.URL = playeFileName;

                    tagList = new List<Tag>();
                    tagList.Clear();

                    //01 02 03 04 텍스트 값 줘야함
                    masterTextBoxSetting(selectName, "01", txt_Clip01);
                    masterTextBoxSetting(selectName, "02", txt_Clip02);
                    masterTextBoxSetting(selectName, "03", txt_Clip03);
                    masterTextBoxSetting(selectName, "04", txt_Clip04);

                    list_Tag.Items.Clear();
                    List<Tag> orderbyList = tagList.OfType<Tag>().OrderByDescending(x => x.count).ToList();
                    for (int i = 0; i < orderbyList.Count; i++)
                    {
                        list_Tag.Items.Add(orderbyList[i].count + " : " + orderbyList[i].tagName);
                    }
                }

                //마스터 태그에서 메세지와 태그를 불러온다.
                StringBuilder sb = new StringBuilder();
                sb.Append("select A.Message, A.Tag from videomastertag A where A.Cat_Type = '" + cmb_MasterCat.Items[cmb_MasterCat.SelectedIndex].ToString() + "'");
                sb.Append(" and A.FileLV_1 = '" + filefb + "'");
                DataSet ds = selectForDataSet(sb.ToString());
                
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    //ds.Tables[0].Rows.Count
                    //Console.WriteLine(item[0] + " "+item[1]);
                    txt_MasterMessage.Text = item[0].ToString();
                    txt_Tag.Text = item[1].ToString();
                }
            }
        }
    }
}
