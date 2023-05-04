using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLights : Form
    {
        bool switchPointer; // для коректного переключання жовтого світла,
                            // яке включається як після червоного, так і після зеленого
        // для задання певних інтервалів - для кожного світла
        double redInterval;
        double yellowInterval;
        double greenInterval;


        public TrafficLights()
        {
            InitializeComponent();
            night_timer.Enabled = false;
            day_timer.Enabled = false;
        }

        private void TrafficLights_Load(object sender, EventArgs e) {}

        /* Виконується при кліці на StartButton - перемикає картинки 
         * з вимкнутого світлофора на жовте світло і навпаки (мигає) 
         * для заданого інтервалу часу*/
        private void night_timer_Tick(object sender, EventArgs e)
        {
            if (darkLight.Visible == true)
            {
                yellowLight.Visible = true;
                darkLight.Visible = false;
            }
            else if (yellowLight.Visible = true)
            {
                yellowLight.Visible = false;
                darkLight.Visible = true;
            }
        }

        /* Виконується при кліці на StartButton - перемикає всі картинки 
         * з певним заданим інтервалом для кожного світла*/
        private void day_timer_Tick(object sender, EventArgs e)
        {
            if (redLight.Visible == true)
            {
                redLight.Visible = false;
                yellowLight.Visible = true;
                day_timer.Interval = int.Parse(yellowInterval.ToString());
            }
            else if (yellowLight.Visible == true && switchPointer == false)
            {
                yellowLight.Visible = false;
                greenLight.Visible = true;
                switchPointer = true;
                day_timer.Interval = int.Parse(greenInterval.ToString());

            }
            else if (greenLight.Visible == true)
            {
                greenLight.Visible = false;
                yellowLight.Visible = true;
                day_timer.Interval = int.Parse(yellowInterval.ToString());

            }
            else if (yellowLight.Visible == true && switchPointer == true)
            {
                yellowLight.Visible = false;
                redLight.Visible = true;
                switchPointer = false;
                day_timer.Interval = int.Parse(redInterval.ToString());

            }
            else
            {
                darkLight.Visible = false;
                redLight.Visible = true;
                day_timer.Interval = int.Parse(redInterval.ToString());
            }
        }

        /* Налаштування видимості компонентів для подальшого вибору варіанту роботи: автоматичний, ручний*/
        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchPointer = false;
            NightIntervalLabel.Visible = false;
            NightIntervalTextBox.Visible = false;

            darkLight.Visible = true;
            redLight.Visible = false;
            yellowLight.Visible = false;
            greenIntervalLabel.Visible = false;
            dayAutoRadioButton.Visible = true;
            dayHandRadioButton.Visible = true;
            managementGroupBox.Visible = true;
        }

        /* Налаштування видимості компонентів для подальшого введення тривалості миготіння жовтого світла*/
        private void nightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchPointer = false;
            NightIntervalLabel.Visible = true;
            NightIntervalTextBox.Visible = true;

            dayAutoRadioButton.Visible = false;
            dayHandRadioButton.Visible= false;
            redIntervalLabel.Visible= false;
            redIntervalTextBox.Visible= false;
            yellowIntervalLabel.Visible = false;
            yellowIntervalTextBox.Visible = false;
            greenIntervalLabel.Visible = false;
            greenIntervalTextBox.Visible = false;
            switchButton.Visible = false;
            managementGroupBox.Visible = false;
            intervalOptionGroupBox.Visible = false;


        }

        /* При виборі автоматичного режиму, дозволяться вибір чи вводити тривалість світіння кожного світла*/
        private void dayAutoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dayDurationYesRadioButton.Visible = true;
            dayDurationNoRadioButton.Visible = true;
            intervalOptionGroupBox.Visible = true;

            switchButton.Visible = false;
        }

        /* При виборі ручного режиму, дозволяться змінювати світло з допомогою кнопки switchButton*/
        private void dayHandRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            redIntervalLabel.Visible = false;
            redIntervalTextBox.Visible = false;
            yellowIntervalLabel.Visible = false;
            yellowIntervalTextBox.Visible = false;
            greenIntervalLabel.Visible = false;
            greenIntervalTextBox.Visible = false;
            intervalOptionGroupBox.Visible = false;

            switchButton.Visible = true;
        }

        /* StartButton_Click використовується, як для запуску світлофора в нічний час, 
         * так і в денний - в автоматичному режимі*/
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (nightRadioButton.Checked == true)
            {
                double nightInterval = double.Parse(NightIntervalTextBox.Text);
                nightInterval *= 1000;
                night_timer.Interval = int.Parse(nightInterval.ToString());
                night_timer.Enabled = true;
            }
            else if (dayDurationYesRadioButton.Checked == true)
            {
                redInterval = double.Parse(redIntervalTextBox.Text);
                redInterval *= 1000;

                yellowInterval = double.Parse(yellowIntervalTextBox.Text);
                yellowInterval *= 1000;

                greenInterval = double.Parse(greenIntervalTextBox.Text);
                greenInterval *= 1000;
                day_timer.Enabled = true;
            }
            else if (dayDurationNoRadioButton.Checked == true)
            {
                redInterval = 3000;
                yellowInterval = 1000;
                greenInterval = 5000;
                day_timer.Enabled = true;
            }

        }

        /* StopButton_Click використовується, для зупинки світлофора в нічний час, і в денний час*/
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (nightRadioButton.Checked == true)
                night_timer.Enabled = false;
            else if (dayAutoRadioButton.Checked == true)
                day_timer.Enabled = false;
        }

        /* Перемикає світло в ручному режимі*/
        private void switchButton_Click(object sender, EventArgs e)
        {
            if (redLight.Visible == true)
            {
                redLight.Visible = false;
                yellowLight.Visible = true;
            }
            else if (yellowLight.Visible == true && switchPointer == false)
            {
                yellowLight.Visible = false;
                greenLight.Visible = true;
                switchPointer = true;
            }
            else if(greenLight.Visible == true)
            {
                greenLight.Visible = false;
                yellowLight.Visible = true;
            }
            else if (yellowLight.Visible == true && switchPointer == true)
            {
                yellowLight.Visible = false;
                redLight.Visible = true;
                switchPointer = false;
            }
            else
            {
                darkLight.Visible = false;
                redLight.Visible = true;
            }

        }

        /* Якщо вибрати Так, то потрібно ввести інтервали світіння кожного світла */
        private void dayDurationYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            redIntervalLabel.Visible = true;
            redIntervalTextBox.Visible = true;

            yellowIntervalLabel.Visible = true;
            yellowIntervalTextBox.Visible = true;

            greenIntervalLabel.Visible = true;
            greenIntervalTextBox.Visible = true;
        }

        /* Якщо вибрати Ні, то автоматично інтервали світіння кожного світла будуть: 
         * червоне 3с; жовте 1с; зелене 5с */
        private void dayDurationNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            redIntervalLabel.Visible = false;
            redIntervalTextBox.Visible = false;

            yellowIntervalLabel.Visible = false;
            yellowIntervalTextBox.Visible = false;

            greenIntervalLabel.Visible = false;
            greenIntervalTextBox.Visible = false;
        }

    }
}
