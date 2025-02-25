using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;
using KryptonCheckBox = Krypton.Toolkit.KryptonCheckBox;
using KryptonRichTextBox = ComponentFactory.Krypton.Toolkit.KryptonRichTextBox;

namespace WindowsFormsApp1.UserControls
{
    public partial class UpdateQuetionsUserControl : UserControl
    {
        int id ;


        public UpdateQuetionsUserControl(int id )
        {
            InitializeComponent();
            cbexamid.SelectedIndexChanged += new EventHandler(cbexamid_SelectedIndexChanged);
            cbqid.SelectedIndexChanged += new EventHandler(cbqid_SelectedIndexChanged);

            index1.CheckedChanged += new EventHandler(checkbox_CheckedChanged);
            index2.CheckedChanged += new EventHandler(checkbox_CheckedChanged);
            index3.CheckedChanged += new EventHandler(checkbox_CheckedChanged);
            index4.CheckedChanged += new EventHandler(checkbox_CheckedChanged);

            this.id = id;
            tbheader.Enter += ClearLbout;
            tbbody.Enter += ClearLbout;
            tbmark.Enter += ClearLbout;
            tboption1.Enter += ClearLbout;
            tboption2.Enter += ClearLbout;
            tboption3.Enter += ClearLbout;
            tboption4.Enter += ClearLbout;
            cbexamid.Enter += ClearLbout;
            cbqid.Enter += ClearLbout;
            index1.Click += ClearLbout;
            index2.Click += ClearLbout;
            index3.Click += ClearLbout;
            index4.Click += ClearLbout;
            btnreset.Enter += ClearLbout;


        }

        private void UpdateQuetionsUserControl_Load(object sender, EventArgs e)
        {
            LoadExamIDs();
        }


        private void ClearLbout(object sender, EventArgs e)
        {
            lbout.Text = "";
        }

        private string currentQuestionType;
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentQuestionType == "truefalse" || currentQuestionType == "chooseone")
            {
                KryptonCheckBox changedCheckbox = sender as KryptonCheckBox;

                if (changedCheckbox.Checked)
                {
                    if (changedCheckbox != index1) index1.Checked = false;
                    if (changedCheckbox != index2) index2.Checked = false;
                    if (changedCheckbox != index3) index3.Checked = false;
                    if (changedCheckbox != index4) index4.Checked = false;


                }
            }
        }

        private void ClearInputs()
        {
            tbheader.Text = string.Empty;
            tbbody.Text = string.Empty;
            tbmark.Text = string.Empty;
            tboption1.Text = string.Empty;
            tboption2.Text = string.Empty;
            tboption3.Text = string.Empty;
            tboption4.Text = string.Empty;

            index1.Checked = false;
            index2.Checked = false;
            index3.Checked = false;
            index4.Checked = false;
        }


        private void LoadExamIDs()
        {
            cbexamid.Items.Clear();
            DataTable dtEX = TeacherBL.GetAllExamsID(id);

            if (dtEX != null && dtEX.Rows.Count > 0)
            {
                foreach (DataRow row in dtEX.Rows)
                {
                    cbexamid.Items.Add(row[0].ToString());
                }
            }
        }

        private void cbexamid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbexamid.SelectedItem == null) return;

            int examid;
            if (int.TryParse(cbexamid.SelectedItem.ToString(), out examid))
            {
                LoadQuestions(examid);
            }
        }

        private void LoadQuestions(int examid)
        {
            cbqid.Items.Clear();
            DataTable dtQ = TeacherBL.GetQuestionsId(examid, id);

            if (dtQ != null && dtQ.Rows.Count > 0)
            {
                foreach (DataRow row in dtQ.Rows)
                {
                    cbqid.Items.Add(row[0].ToString());
                }
            }
        }

        private void cbqid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbqid.SelectedItem == null) return;

            if (int.TryParse(cbqid.SelectedItem.ToString(), out int qid))
            {
                LoadQuestionDetails(qid);
            }
        }

        private int oldQuestionMarks = 0;
        private void LoadQuestionDetails(int qid)
        {
            int examid = int.Parse(cbexamid.SelectedItem.ToString());
            DataTable dt = TeacherBL.GetQuestionByExIdAndQId(examid, qid);

            foreach (DataRow row in dt.Rows)
            {
                currentQuestionType = row["QType"].ToString().ToLower();

                if (currentQuestionType == "truefalse")
                {
                    int.TryParse(row["QID"]?.ToString(), out int quid);
                    int.TryParse(row["Teacher_ID"]?.ToString(), out int teacherId);
                    int.TryParse(row["Exam_ID"]?.ToString(), out int examId);
                    int.TryParse(row["Marks"]?.ToString(), out int marks);

                    int.TryParse(row["Marks"]?.ToString(), out oldQuestionMarks);

                    var correctAnswer = row["CorrectAnswer"]?.ToString()
                                            .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                                            .Select(s => int.TryParse(s, out int val) ? val : -1)
                                            .FirstOrDefault();

                    var options = row["Options"]?.ToString()
                                       .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                                       .ToList() ?? new List<string>();

                    var optionIndices = row["Option_Index"]?.ToString()
                                           .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                                           .Select(s => int.TryParse(s, out int val) ? val : -1)
                                           .ToList() ?? new List<int>();

                    TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(
                        qid,
                        row["Header"]?.ToString() ?? string.Empty,
                        row["Body"]?.ToString() ?? string.Empty,
                        row["QType"]?.ToString() ?? string.Empty,
                        marks > 0 ? (int?)marks : null,
                        teacherId,
                        examId,
                        (int)correctAnswer,
                    options,
                        optionIndices
                    );

                    ClearInputs();

                    tbheader.Text = trueFalseQuestion.Header;
                    tbbody.Text = trueFalseQuestion.Body;
                    tbmark.Text = trueFalseQuestion.Marks?.ToString();

                    tboption1.Enabled = tboption2.Enabled = false;
                    tboption3.Enabled = tboption4.Enabled = false;

                    index1.Enabled = index2.Enabled = true;
                    index3.Enabled = index4.Enabled = false;

                    tboption1.Text = tboption2.Text = string.Empty;

                    if (trueFalseQuestion.Options.Count >= 2)
                    {
                        tboption1.Text = trueFalseQuestion.Options[0];
                        tboption2.Text = trueFalseQuestion.Options[1];

                        if (trueFalseQuestion.Option_Index.Count > 0 &&
                            trueFalseQuestion.CorrectAnswer == trueFalseQuestion.Option_Index[0])
                        {
                            index1.Checked = true;
                        }
                        else
                        {
                            index2.Checked = true;
                        }
                    }
                }


                if (currentQuestionType == "chooseone")
                {
                    ChooseOneQuestion chooseOneQuestion = new ChooseOneQuestion(
                       Convert.ToInt32(row["QID"]),
                        row["Header"].ToString(),
                        row["Body"].ToString(),
                        row["QType"].ToString(),
                        row["Marks"] != DBNull.Value ? (int?)Convert.ToInt32(row["Marks"]) : null,
                        Convert.ToInt32(row["Teacher_ID"]),
                        Convert.ToInt32(row["Exam_ID"]),
                        row["CorrectAnswer"].ToString().Split(',').Select(int.Parse).FirstOrDefault(),
                        row["Options"].ToString().Split(',').ToList(),
                        row["Option_Index"].ToString().Split(',').Select(int.Parse).ToList()
                    );
                    oldQuestionMarks = chooseOneQuestion.Marks.HasValue ? chooseOneQuestion.Marks.Value : 0;

                    tbheader.Text = chooseOneQuestion.Header;
                    tbbody.Text = chooseOneQuestion.Body;
                    tbmark.Text = chooseOneQuestion.Marks?.ToString();

                    tboption1.Enabled = tboption2.Enabled = tboption3.Enabled = tboption4.Enabled = true;
                    index1.Enabled = index2.Enabled = index3.Enabled = index4.Enabled = true;

                    tboption1.Text = tboption2.Text = tboption3.Text = tboption4.Text = string.Empty;
                    index1.Checked = index2.Checked = index3.Checked = index4.Checked = false;

                    for (int i = 0; i < chooseOneQuestion.Options.Count; i++)
                    {
                        if (i < 4)
                        {
                            string optionText = chooseOneQuestion.Options[i];

                            switch (i)
                            {
                                case 0:
                                    tboption1.Text = optionText;
                                    if (chooseOneQuestion.CorrectAnswer == chooseOneQuestion.Option_Index[i]) index1.Checked = true;
                                    break;
                                case 1:
                                    tboption2.Text = optionText;
                                    if (chooseOneQuestion.CorrectAnswer == chooseOneQuestion.Option_Index[i]) index2.Checked = true;
                                    break;
                                case 2:
                                    tboption3.Text = optionText;
                                    if (chooseOneQuestion.CorrectAnswer == chooseOneQuestion.Option_Index[i]) index3.Checked = true;
                                    break;
                                case 3:
                                    tboption4.Text = optionText;
                                    if (chooseOneQuestion.CorrectAnswer == chooseOneQuestion.Option_Index[i]) index4.Checked = true;
                                    break;
                            }
                        }
                    }
                }

                if (currentQuestionType == "chooseall")
                {
                    ChooseAllQuestion chooseAllQuestion = new ChooseAllQuestion(
                        Convert.ToInt32(row["QID"]),
                        row["Header"].ToString(),
                        row["Body"].ToString(),
                        row["QType"].ToString(),
                        row["Marks"] != DBNull.Value ? (int?)Convert.ToInt32(row["Marks"]) : null,
                        Convert.ToInt32(row["Teacher_ID"]),
                        Convert.ToInt32(row["Exam_ID"]),
                        row["CorrectAnswer"].ToString().Split(',')
                            .Select(s => int.Parse(s.Trim())).ToList(),
                        row["Options"].ToString().Split(',').Select(s => s.Trim()).ToList(),
                        row["Option_Index"].ToString().Split(',').Select(s => int.Parse(s.Trim())).ToList()
                    );
                    oldQuestionMarks = chooseAllQuestion.Marks.HasValue ? chooseAllQuestion.Marks.Value : 0;

                    ClearInputs();

                    tbheader.Text = chooseAllQuestion.Header;
                    tbbody.Text = chooseAllQuestion.Body;
                    tbmark.Text = chooseAllQuestion.Marks?.ToString();

                    tboption1.Enabled = tboption2.Enabled = tboption3.Enabled = tboption4.Enabled = true;
                    index1.Enabled = index2.Enabled = index3.Enabled = index4.Enabled = true;

                    tboption1.Text = tboption2.Text = tboption3.Text = tboption4.Text = string.Empty;
                    index1.Checked = index2.Checked = index3.Checked = index4.Checked = false;

                    for (int i = 0; i < chooseAllQuestion.Options.Count; i++)
                    {
                        if (i >= 4) break;

                        string optionText = chooseAllQuestion.Options[i];
                        int optionIndex = chooseAllQuestion.Option_Index[i];

                        switch (i)
                        {
                            case 0:
                                tboption1.Text = optionText;
                                index1.Checked = chooseAllQuestion.CorrectAnswer.Contains(optionIndex);
                                break;
                            case 1:
                                tboption2.Text = optionText;
                                index2.Checked = chooseAllQuestion.CorrectAnswer.Contains(optionIndex);
                                break;
                            case 2:
                                tboption3.Text = optionText;
                                index3.Checked = chooseAllQuestion.CorrectAnswer.Contains(optionIndex);
                                break;
                            case 3:
                                tboption4.Text = optionText;
                                index4.Checked = chooseAllQuestion.CorrectAnswer.Contains(optionIndex);
                                break;
                        }
                    }
                }

            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cbexamid.SelectedItem = null;
            cbqid.SelectedItem = null;
            ClearInputs();
        }

        private ToolTip toolTip = new ToolTip();

        private bool ValidateInputs()
        {
            bool isValid = true;
            toolTip.RemoveAll();

            if (cbexamid.SelectedItem == null)
            {
                toolTip.Show("Please select an Exam ID!", cbexamid, 5000);
                isValid = false;
            }
            if (cbqid.SelectedItem == null)
            {
                toolTip.Show("Please select a Question ID!", cbqid, 5000);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tbheader.Text))
            {
                toolTip.Show("This field is required!", tbheader, 5000);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tbbody.Text))
            {
                toolTip.Show("This field is required!", tbbody, 5000);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tbmark.Text))
            {
                toolTip.Show("This field is required!", tbmark, 5000);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tboption1.Text))
            {
                toolTip.Show("This field is required!", tboption1, 5000);
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tboption2.Text))
            {
                toolTip.Show("This field is required!", tboption2, 5000);
                isValid = false;
            }

            List<KryptonCheckBox> checkBoxes = new List<KryptonCheckBox> { index1, index2, index3, index4 };
            int checkedCount = checkBoxes.Count(cb => cb.Checked);

            if (string.Equals(currentQuestionType, "True/False", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(currentQuestionType, "Choose One", StringComparison.OrdinalIgnoreCase))
            {
                if (checkedCount != 1)
                {
                    toolTip.Show("You must select exactly one correct answer!", index1, 5000);
                    isValid = false;
                }
            }
            else if (string.Equals(currentQuestionType, "Choose All", StringComparison.OrdinalIgnoreCase))
            {
                if (checkedCount < 1)
                {
                    toolTip.Show("You must select at least one correct answer!", index1, 5000);
                    isValid = false;
                }
                else if (checkedCount < 2)
                {
                    toolTip.Show("For 'Choose All', you should select at least two correct answers!", index1, 5000);
                    isValid = false;
                }
            }

            int minLength = 3;

            List<KryptonRichTextBox> textBoxes = new List<KryptonRichTextBox> { tbheader, tbbody };

            foreach (KryptonRichTextBox tb in textBoxes)
            {
                if (tb.Text.Trim().Length < minLength)
                {
                    toolTip.Show($"Minimum {minLength} characters required!", tb, 0, tb.Height, 5000);
                    isValid = false;
                    tb.Focus();
                    break;
                }
            }


            return isValid;
        }

        int totalAllowedMarks = 0;
        int currentTotalMarks = 0;
        int adjustedCurrentMarks = 0;
        private bool ValidateMarks(int examId, int newQuestionMarks, int oldQuestionMarks)
        {
            totalAllowedMarks = TeacherBL.GetTotalAllowedMarksForExam(examId);
            currentTotalMarks = TeacherBL.GetCurrentTotalMarksForExam(examId);

            adjustedCurrentMarks = currentTotalMarks - oldQuestionMarks;

            if (adjustedCurrentMarks + newQuestionMarks > totalAllowedMarks)
            {
                tbmark.Focus();
                return false;
            }

            return true;
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbexamid.SelectedItem == null || cbqid.SelectedItem == null)
                {
                    lbout.Text = "Please Select Exam ID and Question ID";
                    lbout.ForeColor = Color.Red;
                    return;
                }

                if (!ValidateInputs())
                {
                    lbout.Text = "Please fill in all required fields!";
                    lbout.ForeColor = Color.Red;
                    return;
                }

                int qid = int.Parse(cbqid.SelectedItem.ToString());
                int examid = int.Parse(cbexamid.SelectedItem.ToString());
                string header = tbheader.Text.Trim();
                string body = tbbody.Text.Trim();
                string qtype = currentQuestionType;

                int? marks = string.IsNullOrWhiteSpace(tbmark.Text) ? (int?)null : int.Parse(tbmark.Text);


                if (marks.HasValue)
                {
                    if (!ValidateMarks(examid, marks.Value, oldQuestionMarks))
                    {
                        lbout.Text = $"The updated marks exceed the allowed total for this exam.\n" +
                                     $"The total marks for this exam cannot exceed {totalAllowedMarks}. " + $"Current total is {currentTotalMarks}.";
                        lbout.ForeColor = Color.Red;
                        return;
                    }
                }

                List<string> options = new List<string>
                {
                   tboption1.Text.Trim(),
                   tboption2.Text.Trim(),
                   tboption3.Text.Trim(),
                   tboption4.Text.Trim()}.Where(opt => !string.IsNullOrEmpty(opt)).ToList();

                List<int> correctAnswers = new List<int>();
                if (index1.Checked) correctAnswers.Add(1);
                if (index2.Checked) correctAnswers.Add(2);
                if (index3.Checked) correctAnswers.Add(3);
                if (index4.Checked) correctAnswers.Add(4);

                if (!TeacherBL.IsQuestionModified(qid, header, body, qtype, marks, options, correctAnswers))
                {
                    lbout.Text = "No changes detected!";
                    lbout.ForeColor = Color.Blue;
                    return;
                }

                int result = TeacherBL.UpdateQuestion(qid, examid, header, body, qtype, marks, correctAnswers, options, Enumerable.Range(1, options.Count).ToList());

                if (result > 0)
                {
                    lbout.Text = "Question updated successfully!";
                    lbout.ForeColor = Color.Green;
                }
                else
                {
                    lbout.Text = "Failed to update question!";
                    lbout.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lbout.Text = "Failed to update question!";
                lbout.ForeColor = Color.Red;
            }
        }

    }
}
