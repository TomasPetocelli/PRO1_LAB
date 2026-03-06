using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_3
{
    abstract class Student {
        protected int vmesna;
        protected int koncna;
        protected int seminar;
        protected int ustna;

        protected double ocena;

        public Student() { }

        public int Vmesna { 
            get { return vmesna; } 
            set { 
                if (value < 5 | value > 10) {
                    MessageBox.Show("Aplikacija se zapira.", "NAPAKA");
                } else {
                    vmesna = value;
                }//Konec if-esle
            }//Konec get-set
        }//Konec Vmesna

        public int Koncna {
            get { return koncna; }
            set {
                if (value < 5 | value > 10) {
                    MessageBox.Show("Aplikacija se zapira.", "NAPAKA");
                } else {
                    koncna = value;
                }//Konec if-esle
            }//Konec get-set
        }//Konec Koncna

        public int Seminar {
            get { return seminar; }
            set {
                if (value < 5 | value > 10) {
                    MessageBox.Show("Aplikacija se zapira.", "NAPAKA");
                } else {
                    seminar = value;
                }//Konec if-esle
            }//Konec get-set
        }//Konec Seminar

        public int Ustna {
            get { return ustna; }
            set {
                if (value < 5 | value > 10) {
                    MessageBox.Show("Aplikacija se zapira.", "NAPAKA");
                } else {
                    ustna = value;
                }//Konec if-esle
            }//Konec get-set
        }//Konec Ustna

        public double Ocena {
            get { return ocena; }
        }//Konec Ocena

        public abstract void Racunaj();
    }//Konec class Student
}
