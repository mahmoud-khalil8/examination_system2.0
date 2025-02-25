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
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class AddNewQuestionsUC : UserControl
    {

        private int optionCount = 2;
        private List<KryptonTextBox> optionTextBoxes = new List<KryptonTextBox>();
        private List<KryptonCheckBox> correctAnswerCheckboxes = new List<KryptonCheckBox>();
        private List<KryptonRadioButton> correctAnswerRadioButtons = new List<KryptonRadioButton>();
        private string questionType = "";
        KryptonTextBox txtHeader;
        KryptonTextBox txtBody;
        KryptonRadioButton rbtnTrue;
        KryptonRadioButton rbtnFalse;
        KryptonNumericUpDown numMarks;
        private int sumOfQuestionsAdded = 0;
        TrueFalseQuestion trueFalseQ = new TrueFalseQuestion();
        ChooseOneQuestion chooseOneQ = new ChooseOneQuestion();
        ChooseAllQuestion chooseAllQ = new ChooseAllQuestion();

        int userId;
        public AddNewQuestionsUC(int _id)
        {
            InitializeComponent();
            var e = AddNewQuestionsUCBusiness.GetCurrentExam(userId);
            userId = _id;

            if (e.Rows.Count != 0)
            {
                DropDownMenu.Text = e.Rows[0]["ExamName"].ToString();
                UpdateMarks();
            }
            PopulateContextMenu(AddNewQuestionsUCBusiness.GetExams(userId));
            DropDownMenu.KryptonContextMenu = kryptonContextMenu1;

        }

        private void SetButtonDefaultStyle(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = Color.Black;
            button.OverrideDefault.Back.Color2 = Color.Black;
            button.OverrideDefault.Content.ShortText.Color1 = Color.White;
            button.OverrideDefault.Content.ShortText.Color2 = Color.White;
            button.StateCommon.Back.Color1 = Color.Black;
            button.StateCommon.Back.Color2 = Color.Black;
            button.StateCommon.Content.ShortText.Color1 = Color.White;
            button.StateCommon.Content.ShortText.Color2 = Color.White;
            button.StateNormal.Back.Color1 = Color.Black;
            button.StateNormal.Back.Color2 = Color.Black;
            button.StateNormal.Content.ShortText.Color1 = Color.White;
            button.StateNormal.Content.ShortText.Color2 = Color.White;
            button.StateTracking.Back.Color1 = Color.Empty;
            button.StateTracking.Back.Color2 = Color.Empty;
            button.StateTracking.Content.ShortText.Color1 = Color.White;
            button.StateTracking.Content.ShortText.Color2 = Color.White;
        }

        private void SetButtonActiveStyle(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = Color.White;
            button.OverrideDefault.Back.Color2 = Color.White;
            button.OverrideDefault.Content.ShortText.Color1 = Color.Black;
            button.OverrideDefault.Content.ShortText.Color2 = Color.Black;
            button.StateCommon.Back.Color1 = Color.White;
            button.StateCommon.Back.Color2 = Color.White;
            button.StateCommon.Content.ShortText.Color1 = Color.Black;
            button.StateCommon.Content.ShortText.Color2 = Color.Black;
            button.StateNormal.Back.Color1 = Color.White;
            button.StateNormal.Back.Color2 = Color.White;
            button.StateNormal.Content.ShortText.Color1 = Color.Black;
            button.StateNormal.Content.ShortText.Color2 = Color.Black;
            button.StateTracking.Back.Color1 = Color.Empty;
            button.StateTracking.Back.Color2 = Color.Empty;
            button.StateTracking.Content.ShortText.Color1 = Color.Empty;
            button.StateTracking.Content.ShortText.Color2 = Color.Empty;
        }

        private void TrueFalseBTN_Click(object sender, EventArgs e)
        {
            SetButtonDefaultStyle(ChooseOneBTN);
            SetButtonDefaultStyle(ChooseAllBTN);
            SetButtonActiveStyle(TrueFalseBTN);
            questionType = "TrueFalse";
            GenerateQuestionForm();
        }

        private void ChooseOneBTN_Click(object sender, EventArgs e)
        {
            SetButtonDefaultStyle(TrueFalseBTN);
            SetButtonDefaultStyle(ChooseAllBTN);
            SetButtonActiveStyle(ChooseOneBTN);
            questionType = "ChooseOne";
            GenerateQuestionForm();
        }

        private void ChooseAllBTN_Click(object sender, EventArgs e)
        {
            SetButtonDefaultStyle(ChooseOneBTN);
            SetButtonDefaultStyle(TrueFalseBTN);
            SetButtonActiveStyle(ChooseAllBTN);
            questionType = "ChooseAll";
            GenerateQuestionForm();
        }

        private void GenerateQuestionForm()
        {
            questionPanel.Controls.Clear();
            optionTextBoxes.Clear();
            correctAnswerCheckboxes.Clear();
            correctAnswerRadioButtons.Clear();

            int startX = 33;
            int startY = 10;
            int labelWidth = 150;
            int textBoxWidth = 300;
            int rowHeight = 50;

            // Add question header, body, and marks
            KryptonLabel lblHeader = CreateStyledLabel("Question Header:", startX, startY);
            txtHeader = CreateStyledTextBox(startX + labelWidth, startY, textBoxWidth);

            KryptonLabel lblBody = CreateStyledLabel("Question Body:", startX, startY + rowHeight);
            txtBody = CreateStyledTextBox(startX + labelWidth, startY + rowHeight, textBoxWidth);

            KryptonLabel lblMarks = CreateStyledLabel("Marks:", startX, startY + (rowHeight * 2));
            numMarks = new KryptonNumericUpDown()
            {
                Location = new Point(startX + labelWidth, startY + (rowHeight * 2)),
                Width = 100,
                Minimum = 1,
                Maximum = 100
            };
            numMarks.ValueChanged += NumMarks_ValueChanged;

            questionPanel.Controls.Add(lblHeader);
            questionPanel.Controls.Add(txtHeader);
            questionPanel.Controls.Add(lblBody);
            questionPanel.Controls.Add(txtBody);
            questionPanel.Controls.Add(lblMarks);
            questionPanel.Controls.Add(numMarks);

            if (questionType == "ChooseOne" || questionType == "ChooseAll")
            {
                int buttonsX = startX + labelWidth + 130;
                int buttonsY = startY + (rowHeight * 2);

                KryptonButton btnAddOption = CreateStyledButton("Add Option", buttonsX, buttonsY);
                btnAddOption.Height = 30;
                btnAddOption.Click += (s, e) => AddOption();

                KryptonButton btnRemoveOption = CreateStyledButton("Remove Option", buttonsX + 130, buttonsY);
                btnRemoveOption.Height = 30;
                btnRemoveOption.Click += (s, e) => RemoveOption();

                questionPanel.Controls.Add(btnAddOption);
                questionPanel.Controls.Add(btnRemoveOption);

                for (int i = 0; i < optionCount; i++)
                {
                    AddOption();
                }
            }
            else if (questionType == "TrueFalse")
            {
                // Get the Marks textbox (KryptonNumericUpDown) control
                var marksControl = questionPanel.Controls.OfType<KryptonNumericUpDown>().FirstOrDefault();

                if (marksControl != null)
                {
                    // Position the Correct Answer label and radio buttons to the right of the Marks textbox
                    int correctAnswerStartX = marksControl.Right + 20; // 20 pixels to the right of the Marks textbox
                    int correctAnswerStartY = marksControl.Top; // Align with the top of the Marks textbox

                    KryptonLabel lblCorrectAnswer = CreateStyledLabel("Correct Answer:", correctAnswerStartX, correctAnswerStartY);
                    rbtnTrue = new KryptonRadioButton()
                    {
                        Text = "True",
                        Location = new Point(correctAnswerStartX + labelWidth, correctAnswerStartY)
                    };
                    rbtnFalse = new KryptonRadioButton()
                    {
                        Text = "False",
                        Location = new Point(correctAnswerStartX + labelWidth + 70, correctAnswerStartY)
                    };

                    questionPanel.Controls.Add(lblCorrectAnswer);
                    questionPanel.Controls.Add(rbtnTrue);
                    questionPanel.Controls.Add(rbtnFalse);
                }
                else
                {
                    // Fallback position if Marks textbox is not found
                    KryptonLabel lblCorrectAnswer = CreateStyledLabel("Correct Answer:", startX, startY + (rowHeight * 3));
                    KryptonRadioButton rbtnTrue = new KryptonRadioButton()
                    {
                        Text = "True",
                        Location = new Point(startX + labelWidth, startY + (rowHeight * 3))
                    };
                    KryptonRadioButton rbtnFalse = new KryptonRadioButton()
                    {
                        Text = "False",
                        Location = new Point(startX + labelWidth + 70, startY + (rowHeight * 3))
                    };

                    questionPanel.Controls.Add(lblCorrectAnswer);
                    questionPanel.Controls.Add(rbtnTrue);
                    questionPanel.Controls.Add(rbtnFalse);
                }
            }

            AddActionButtons();
        }
        private bool isUserInput = true;
        private void NumMarks_ValueChanged(object sender, EventArgs e)
        {
            if (!isUserInput) return;
            var exam = AddNewQuestionsUCBusiness.GetCurrentExam(userId);
            if (exam.Rows.Count == 0) return;
            var examMarks = Convert.ToInt32(exam.Rows[0]["Exam_Marks"]);
            var questions = AddNewQuestionsUCBusiness.GetExamQuestions(userId);
            for (int i = 0; i < questions.Rows.Count; i++)
            {
                sumOfQuestionsAdded += Convert.ToInt32(questions.Rows[i]["Marks"]);
            }
            if (numMarks.Value > (examMarks - sumOfQuestionsAdded))
            {
                MessageBox.Show("You cannot add more marks than the total marks of the exam.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isUserInput = false;
                numMarks.Value = examMarks - sumOfQuestionsAdded;
                isUserInput = true;
            }
            sumOfQuestionsAdded = 0;
        }

        private void AddOption()
        {
            if (optionTextBoxes.Count >= 7)
            {
                MessageBox.Show("You cannot add more than 7 options.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int startX = 33;
            int startY = 160 + (optionTextBoxes.Count * 50);
            int labelWidth = 150;
            int textBoxWidth = 300;

            KryptonLabel lblOption = CreateStyledLabel($"Option {optionTextBoxes.Count + 1}:", startX, startY);
            KryptonTextBox txtOption = CreateStyledTextBox(startX + labelWidth, startY, textBoxWidth);

            questionPanel.Controls.Add(lblOption);
            questionPanel.Controls.Add(txtOption);
            optionTextBoxes.Add(txtOption);

            if (questionType == "ChooseOne")
            {
                KryptonRadioButton rbtnCorrect = new KryptonRadioButton()
                {
                    Location = new Point(startX + labelWidth + textBoxWidth + 10, startY)
                };
                correctAnswerRadioButtons.Add(rbtnCorrect);
                questionPanel.Controls.Add(rbtnCorrect);
            }
            else if (questionType == "ChooseAll")
            {
                KryptonCheckBox chkCorrect = new KryptonCheckBox()
                {
                    Location = new Point(startX + labelWidth + textBoxWidth + 10, startY)
                };
                correctAnswerCheckboxes.Add(chkCorrect);
                questionPanel.Controls.Add(chkCorrect);
            }

            // Reposition "Add Question" and "Reset" buttons
            AddActionButtons();
        }
        private void ValidateNumberOfQuestion()
        {
            var NOQA = AddNewQuestionsUCBusiness.GetNumberOfQuestionsAdded(userId);
            var NOQ = AddNewQuestionsUCBusiness.GetNumberOfQuestionsInExam(userId);
            var TM = AddNewQuestionsUCBusiness.GetTotalMarks(userId);
            var SM = AddNewQuestionsUCBusiness.GetSumOfMarks(userId);
            if (NOQA >= NOQ)
            {
                MessageBox.Show("You cannot add more questions than the total number of questions in the exam.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Disable specific controls (textboxes, buttons, checkboxes, radio buttons, numeric up-downs)
                DisableSpecificControls();
                AddNewQuestionsUCBusiness.UpdateTotalMarks(userId);
                UpdateMarks();

            }
            else if (SM >= TM)
            {
                MessageBox.Show("You cannot add more marks than the total marks of the exam.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisableSpecificControls();
                AddNewQuestionsUCBusiness.UpdateQuesNum(userId);
                UpdateMarks();
            }
            else
            {
                // Enable all controls if the condition is not met
                EnableAllControls();
            }
        }

        private void DisableSpecificControls()
        {
            foreach (Control control in this.Controls)
            {
                // Disable only specific control types
                if (control is KryptonTextBox || control is KryptonButton || control is KryptonCheckBox || control is KryptonRadioButton || control is KryptonNumericUpDown)
                {
                    control.Enabled = false;
                }

                // Recursively check controls inside containers (e.g., panels, group boxes)
                if (control.HasChildren)
                {
                    DisableSpecificControlsRecursive(control);
                }
            }
        }

        private void DisableSpecificControlsRecursive(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Disable only specific control types
                if (control is KryptonTextBox || control is KryptonButton || control is KryptonCheckBox || control is KryptonRadioButton || control is KryptonNumericUpDown)
                {
                    control.Enabled = false;
                }

                // Recursively check controls inside containers
                if (control.HasChildren)
                {
                    DisableSpecificControlsRecursive(control);
                }
            }
        }

        private void EnableAllControls()
        {
            foreach (Control control in this.Controls)
            {
                // Enable all controls
                control.Enabled = true;

                // Recursively enable controls inside containers
                if (control.HasChildren)
                {
                    EnableAllControlsRecursive(control);
                }
            }
        }

        private void EnableAllControlsRecursive(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Enable all controls
                control.Enabled = true;

                // Recursively enable controls inside containers
                if (control.HasChildren)
                {
                    EnableAllControlsRecursive(control);
                }
            }
        }
        private void RemoveOption()
        {
            if (optionTextBoxes.Count > 0)
            {
                int lastIndex = optionTextBoxes.Count - 1;

                questionPanel.Controls.Remove(optionTextBoxes[lastIndex]);
                optionTextBoxes.RemoveAt(lastIndex);

                var labelToRemove = questionPanel.Controls.OfType<KryptonLabel>()
                    .FirstOrDefault(lbl => lbl.Text == $"Option {lastIndex + 1}:");
                if (labelToRemove != null)
                {
                    questionPanel.Controls.Remove(labelToRemove);
                }

                if (questionType == "ChooseOne" && correctAnswerRadioButtons.Count > 0)
                {
                    questionPanel.Controls.Remove(correctAnswerRadioButtons[lastIndex]);
                    correctAnswerRadioButtons.RemoveAt(lastIndex);
                }
                else if (questionType == "ChooseAll" && correctAnswerCheckboxes.Count > 0)
                {
                    questionPanel.Controls.Remove(correctAnswerCheckboxes[lastIndex]);
                    correctAnswerCheckboxes.RemoveAt(lastIndex);
                }
                if (optionTextBoxes.Count < 2)
                {
                    MessageBox.Show("You must add at least 2 options.", "Minimum Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AddOption();
                    return;
                }
                questionPanel.Refresh();

                // Reposition "Add Question" and "Reset" buttons
                AddActionButtons();
            }
        }

        private void AddActionButtons()
        {
            int startX = 33;
            int startY = 160 + (optionTextBoxes.Count * 50); // Position below the last option
            int buttonWidth = 120;
            int buttonHeight = 30;
            int buttonSpacing = 20;

            // Remove existing buttons if they exist
            var existingButtons = questionPanel.Controls.OfType<KryptonButton>().Where(b => b.Text == "Add Question" || b.Text == "Reset").ToList();
            foreach (var button in existingButtons)
            {
                questionPanel.Controls.Remove(button);
            }

            // Add "Add Question" button
            KryptonButton btnAddQuestion = CreateStyledButton("Add Question", startX, startY);
            btnAddQuestion.Width = buttonWidth;
            btnAddQuestion.Height = buttonHeight;
            btnAddQuestion.Click += (s, e) => AddQuestion();

            // Add "Reset" button
            KryptonButton btnReset = CreateStyledButton("Reset", startX + buttonWidth + buttonSpacing, startY);
            btnReset.Width = buttonWidth;
            btnReset.Height = buttonHeight;
            btnReset.Click += (s, e) => ResetForm();

            questionPanel.Controls.Add(btnAddQuestion);
            questionPanel.Controls.Add(btnReset);
        }

        private void AddQuestion()
        {
            if (!ValidateInput()) // Check if all required fields are filled
            {
                return; // Stop execution if validation fails
            }
            Submit();
            UpdateMarks();
            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            ValidateNumberOfQuestion();
        }
        private bool ValidateInput()
        {
            if (TeacherDashoard.CurrentExamID == 0)
            {
                MessageBox.Show("Please select an exam.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Check if Header and Body are filled
            if (string.IsNullOrWhiteSpace(txtHeader.Text))
            {
                MessageBox.Show("Please enter a question header.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBody.Text))
            {
                MessageBox.Show("Please enter a question body.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if Marks are greater than 0
            if (numMarks.Value <= 0)
            {
                MessageBox.Show("Marks should be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate based on question type
            if (questionType == "TrueFalse")
            {
                if (!rbtnTrue.Checked && !rbtnFalse.Checked)
                {
                    MessageBox.Show("Please select the correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (questionType == "ChooseOne")
            {
                if (optionTextBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
                {
                    MessageBox.Show("Please enter at least two options and ensure no empty options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!correctAnswerRadioButtons.Any(rb => rb.Checked))
                {
                    MessageBox.Show("Please select a correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (questionType == "ChooseAll")
            {
                if (optionTextBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
                {
                    MessageBox.Show("Please enter at least two options and ensure no empty options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!correctAnswerCheckboxes.Any(cb => cb.Checked))
                {
                    MessageBox.Show("Please select at least one correct answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true; // All validations passed
        }

        private void ResetForm()
        {
            // Reset the form to its default state
            questionPanel.Controls.Clear();
            optionTextBoxes.Clear();
            correctAnswerCheckboxes.Clear();
            correctAnswerRadioButtons.Clear();
            optionCount = 2;
            GenerateQuestionForm();
        }

        private void PopulateContextMenu(DataTable table)
        {
            // Clear existing menu items
            kryptonContextMenu1.Items.Clear();
            KryptonContextMenuItems menuItemsCollection = new KryptonContextMenuItems();

            // Iterate through the DataTable and add menu items
            foreach (DataRow row in table.Rows)
            {
                string menuItemText = row["ExamName"].ToString();
                int examID = Convert.ToInt32(row["Exam_ID"]);
                var menuItem = new KryptonContextMenuItem(menuItemText)
                {
                    Tag = examID
                };
                menuItem.Click += MenuItem_Click;
                menuItemsCollection.Items.Add(menuItem);
            }
            kryptonContextMenu1.Items.Add(menuItemsCollection);
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is KryptonContextMenuItem menuItem)
            {
                if (!isUserInput) return;
                DropDownMenu.Text = menuItem.Text;
                int selectedExamID = (int)menuItem.Tag;
                TeacherDashoard.CurrentExamID = selectedExamID;
                if (numMarks != null)
                {
                    isUserInput = false;
                    numMarks.Value = 1;
                    isUserInput = true;
                }
                UpdateMarks();
                ValidateNumberOfQuestion();
            }
        }
        private void UpdateMarks()
        {
            var exam = AddNewQuestionsUCBusiness.GetCurrentExam(userId);
            var examMarks = exam.Rows[0]["Exam_Marks"].ToString();
            var questions = AddNewQuestionsUCBusiness.GetExamQuestions(userId);
            for (int i = 0; i < questions.Rows.Count; i++)
            {
                sumOfQuestionsAdded += Convert.ToInt32(questions.Rows[i]["Marks"]);
            }
            mark.Text = "Marks Sum of Questions Added : " + sumOfQuestionsAdded.ToString() + " / " + examMarks;
            sumOfQuestionsAdded = 0;
        }
        private void Submit()
        {
            if (questionType == "TrueFalse")
            {
                trueFalseQ.Header = txtHeader.Text;
                trueFalseQ.Body = txtBody.Text;
                trueFalseQ.Marks = (int)numMarks.Value;
                trueFalseQ.QType = questionType;
                trueFalseQ.Exam_ID = TeacherDashoard.CurrentExamID;
                trueFalseQ.Teacher_ID = userId;
                trueFalseQ.Options = new List<string> { "True", "False" };
                trueFalseQ.Option_Index = new List<int> { 1, 2 };
                if (rbtnTrue.Checked)
                {
                    trueFalseQ.CorrectAnswer = 1;
                }
                else if (rbtnFalse.Checked)
                {
                    trueFalseQ.CorrectAnswer = 2;
                }
                AddNewQuestionsUCBusiness.InsertQuestion(trueFalseQ);
                var qID = AddNewQuestionsUCBusiness.GetQID();
                trueFalseQ.QID = qID;
                AddNewQuestionsUCBusiness.InsertOptions(trueFalseQ);
                AddNewQuestionsUCBusiness.InsertCorrectAnswer(trueFalseQ);
            }
            else if(questionType == "ChooseOne")
{
                chooseOneQ.Header = txtHeader.Text;
                chooseOneQ.Body = txtBody.Text;
                chooseOneQ.Marks = (int)numMarks.Value;
                chooseOneQ.QType = questionType;
                chooseOneQ.Exam_ID = TeacherDashoard.CurrentExamID;
                chooseOneQ.Teacher_ID = userId;

                chooseOneQ.Options = new List<string>();
                chooseOneQ.Option_Index = new List<int>();

                for (int i = 0; i < optionTextBoxes.Count; i++)
                {
                    chooseOneQ.Options.Add(optionTextBoxes[i].Text);
                    chooseOneQ.Option_Index.Add(i + 1);
                    if (correctAnswerRadioButtons[i].Checked)
                    {
                        chooseOneQ.CorrectAnswer = i + 1;
                    }
                }

                AddNewQuestionsUCBusiness.InsertQuestion(chooseOneQ);

                var qID = AddNewQuestionsUCBusiness.GetQID();

                

                chooseOneQ.QID = qID;

                AddNewQuestionsUCBusiness.InsertOptions(chooseOneQ);
                AddNewQuestionsUCBusiness.InsertCorrectAnswer(chooseOneQ);
            }

            else if (questionType == "ChooseAll")
            {
                chooseAllQ.Header = txtHeader.Text;
                chooseAllQ.Body = txtBody.Text;
                chooseAllQ.Marks = (int)numMarks.Value;
                chooseAllQ.QType = questionType;
                chooseAllQ.Exam_ID = TeacherDashoard.CurrentExamID;
                chooseAllQ.Teacher_ID = userId;
                chooseAllQ.Options = new List<string>();
                chooseAllQ.Option_Index = new List<int>();
                chooseAllQ.CorrectAnswer = new List<int>();
                for (int i = 0; i < optionTextBoxes.Count; i++)
                {
                    chooseAllQ.Options.Add(optionTextBoxes[i].Text);
                    chooseAllQ.Option_Index.Add(i + 1);
                    if (correctAnswerCheckboxes[i].Checked)
                    {
                        chooseAllQ.CorrectAnswer.Add(i + 1);
                    }
                }
                AddNewQuestionsUCBusiness.InsertQuestion(chooseAllQ);
                var qID = AddNewQuestionsUCBusiness.GetQID();
                chooseAllQ.QID = qID;
                AddNewQuestionsUCBusiness.InsertOptions(chooseAllQ);
                AddNewQuestionsUCBusiness.InsertCorrectAnswer(chooseAllQ);
            }
        }
        private KryptonLabel CreateStyledLabel(string text, int x, int y) =>
            new KryptonLabel() { Text = text, Location = new Point(x, y), AutoSize = true, StateCommon = { ShortText = { Font = new Font("Segoe UI", 12) } } };

        private KryptonTextBox CreateStyledTextBox(int x, int y, int width) =>
            new KryptonTextBox() { Location = new Point(x, y), Width = width, StateCommon = { Content = { Font = new Font("Segoe UI", 12) }, Border = { Rounding = 15, Width = 1 } } };

        private KryptonButton CreateStyledButton(string text, int x, int y) =>
            new KryptonButton() { Text = text, Location = new Point(x, y), Width = 120, StateCommon = { Content = { ShortText = { Font = new Font("Segoe UI", 8) } }, Border = { Rounding = 15, Width = 1 } } };

        private void DropDownMenu_Click(object sender, EventArgs e)
        {

        }

        private void AddNewQuestionsUC_Load(object sender, EventArgs e)
        {

        }
    }
}
