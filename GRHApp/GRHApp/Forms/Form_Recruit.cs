using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.UserControls;
using GRHApp.Classes;
using GRHApp.Properties;

namespace GRHApp.Forms
{
    public partial class Form_Recruit : Form
    {
        //For UC_CivilState:
        public delegate void fNameFunction(string matValue, string fnameValue, string nameValue, string nameBefValue, DateTime birthDate, string bPlaceValue, string nationValue, string famStiValue, string adressValue, string phone, string fathName, string mothFullName, string bloodTy, string fathJob, string mothJob, string siblingNum, string marName, DateTime miriDate, string marJob, string childNum, string accountNum, string securNum, string carteNum, string deliverBy, DateTime deliverDate);
        private event fNameFunction someMat;

        public string _LName;
        public string _Mat;
        public string _Name;
        public string _NameBefo;
        public string _BirthD;
        public string _BirthP;
        public string _FamSit;
        public string _Nation;
        public string _Adress;
        public string _Phone;
        public string _FathName;
        public string _MothFullName;
        public string _BloodType;
        public string _FathJob;
        public string _MotJob;
        public string _SiblingNum;
        public string _MariName;
        public string _MariDate;
        public string _MariJob;
        public string __ChildNum;
        public string _AccountNum;
        public string _SecuNum;
        public string _CarteNum;
        public string _DeliverBy;
        public string _DeliverDate;
        
        private void someOtherName(string matValue, string fnameValue, string nameValue, string nameBefValue, DateTime birthDate, string bPlaceValue, string nationValue, string famStiValue, string adressValue, string phone, string fathName, string mothFullName, string bloodTy, string fathJob, string mothJob, string siblingNum, string marName, DateTime miriDate, string marJob, string childNum, string accountNum, string securNum, string carteNum, string deliverBy, DateTime deliverDate)
        {
            _Mat = matValue;
            _LName = fnameValue;
            _Name = nameValue;
            _NameBefo = nameBefValue;
            _BirthD = birthDate.ToShortDateString();
            _BirthP = bPlaceValue;
            _FamSit = famStiValue;
            _Nation = nationValue;
            _Adress = adressValue;
            _Phone = phone;
            _FathName = fathName;
            _MothFullName = mothFullName;
            _BloodType = bloodTy;
            _SiblingNum = siblingNum;
            _FathJob = fathJob;
            _MotJob = mothJob;
            _MariName = marName;
            _MariDate = miriDate.ToShortDateString();
            _MariJob = marJob;
            __ChildNum = childNum;
            _AccountNum = accountNum;
            _SecuNum = securNum;
            _CarteNum = carteNum;
            _DeliverBy = deliverBy;
            _DeliverDate = deliverDate.ToShortDateString();
        }

        //For UC_Military:
        public delegate void fNameFunction1(string engage, DateTime immoDate, DateTime sursiFrom, DateTime sursiTo, string apte);
        private event fNameFunction1 someMat1;

        public string _Engage;
        public string _ImmoDate;
        public string _SursiFrom;
        public string _SursiTo;
        public string _Apte;


        private void someOtherName1(string engage, DateTime immoDate, DateTime sursiFrom, DateTime sursiTo, string apte)
        {
            _Engage = engage;
            _ImmoDate = immoDate.ToShortDateString();
            _SursiFrom = sursiFrom.ToShortDateString();
            _SursiTo = sursiTo.ToShortDateString();
            _Apte = apte;
        }

        //For UC_StudyLevel:
        public delegate void fNameFunction2(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4);
        private event fNameFunction2 someMat2;

        public string _Etab1;
        public string _Speci1;
        public string _Period1;
        public string _Dipl1;
        public string _ObtDate1;
        public string _Etab2;
        public string _Speci2;
        public string _Period2;
        public string _Dipl2;
        public string _ObtDate2;
        public string _Etab3;
        public string _Speci3;
        public string _Period3;
        public string _Dipl3;
        public string _ObtDate3;
        public string _Etab4;
        public string _Speci4;
        public string _Period4;
        public string _Dipl4;
        public string _ObtDate4;

        private void someOtherName2(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4)
        {
            _Etab1 = etab1;
            _Speci1 = spaci1;
            _Period1 = perio1;
            _Dipl1 = dipl1;
            _ObtDate1 = obtDate1;
            _Etab2 = etab2;
            _Speci2 = spaci2;
            _Period2 = perio2;
            _Dipl2 = dipl2;
            _ObtDate2 = obtDate2;
            _Etab3 = etab3;
            _Speci3 = spaci3;
            _Period3 = perio3;
            _Dipl3 = dipl3;
            _ObtDate3 = obtDate3;
            _Etab4 = etab4;
            _Speci4 = spaci4;
            _Period4 = perio4;
            _Dipl4 = dipl4;
            _ObtDate4 = obtDate4;
        }

        //UC_ProfStudy:
        public delegate void fNameFunction3(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4);
        private event fNameFunction3 someMat3;

        public string _Etabl1;
        public string _Spec1;
        public string _Perio1;
        public string _Dip1;
        public string _ObtenDate1;
        public string _Etabl2;
        public string _Spec2;
        public string _Perio2;
        public string _Dip2;
        public string _ObtenDate2;
        public string _Etabl3;
        public string _Spec3;
        public string _Perio3;
        public string _Dip3;
        public string _ObtenDate3;
        public string _Etabl4;
        public string _Spec4;
        public string _Perio4;
        public string _Dip4;
        public string _ObtenDate4;

        private void someOtherName3(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4)
        {
            _Etabl1 = etab1;
            _Spec1 = spaci1;
            _Perio1 = perio1;
            _Dip1 = dipl1;
            _ObtenDate1 = obtDate1;
            _Etabl2 = etab2;
            _Spec2 = spaci2;
            _Perio2 = perio2;
            _Dip2 = dipl2;
            _ObtenDate2 = obtDate2;
            _Etabl3 = etab3;
            _Spec3 = spaci3;
            _Perio3 = perio3;
            _Dip3 = dipl3;
            _ObtenDate3 = obtDate3;
            _Etabl4 = etab4;
            _Spec4 = spaci4;
            _Perio4 = perio4;
            _Dip4 = dipl4;
            _ObtenDate4 = obtDate4;
        }

        //UC_Trainings:
        public delegate void fNameFunction4(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4);
        private event fNameFunction4 someMat4;

        public string _E1;
        public string _S1;
        public string _P1;
        public string _D1;
        public string _O1;
        public string _E2;
        public string _S2;
        public string _P2;
        public string _D2;
        public string _O2;
        public string _E3;
        public string _S3;
        public string _P3;
        public string _D3;
        public string _O3;
        public string _E4;
        public string _S4;
        public string _P4;
        public string _D4;
        public string _O4;

        private void someOtherName4(string etab1, string spaci1, string perio1, string dipl1, string obtDate1, string etab2, string spaci2, string perio2, string dipl2, string obtDate2, string etab3, string spaci3, string perio3, string dipl3, string obtDate3, string etab4, string spaci4, string perio4, string dipl4, string obtDate4)
        {
            _E1 = etab1;
            _S1 = spaci1;
            _P1 = perio1;
            _D1 = dipl1;
            _O1 = obtDate1;
            _E2 = etab2;
            _S2 = spaci2;
            _P2 = perio2;
            _D2 = dipl2;
            _O2 = obtDate2;
            _E3 = etab3;
            _S3 = spaci3;
            _P3 = perio3;
            _D3 = dipl3;
            _O3 = obtDate3;
            _E4 = etab4;
            _S4 = spaci4;
            _P4 = perio4;
            _D4 = dipl4;
            _O4 = obtDate4;
        }

        //UC_Career:
        public delegate void fNameFunction5(string emp1, string work1, string from1, string to1, string motive1, string emp2, string work2, string from2, string to2, string motive2, string emp3, string work3, string from3, string to3, string motive3, string emp4, string work4, string from4, string to4, string motive4);
        private event fNameFunction5 someMat5;

        public string _Emp1;
        public string _Work1;
        public string _From1;
        public string _To1;
        public string _Motive1;
        public string _Emp2;
        public string _Work2;
        public string _From2;
        public string _To2;
        public string _Motive2;
        public string _Emp3;
        public string _Work3;
        public string _From3;
        public string _To3;
        public string _Motive3;
        public string _Emp4;
        public string _Work4;
        public string _From4;
        public string _To4;
        public string _Motive4;

        private void someOtherName5(string emp1, string work1, string from1, string to1, string motive1, string emp2, string work2, string from2, string to2, string motive2, string emp3, string work3, string from3, string to3, string motive3, string emp4, string work4, string from4, string to4, string motive4)
        {
            _Emp1 = emp1;
            _Work1 = work1;
            _From1 = from1;
            _To1 = to1;
            _Motive1 = motive1;
            _Emp2 = emp2;
            _Work2 = work2;
            _From2 = from2;
            _To2 = to2;
            _Motive2 = motive2;
            _Emp3 = emp3;
            _Work3 = work3;
            _From3 = from3;
            _To3 = to3;
            _Motive3 = motive3;
            _Emp4 = emp4;
            _Work4 = work4;
            _From4 = from4;
            _To4 = to4;
            _Motive4 = motive4;
        }

        //UC_Language:
        public delegate void fNameFunction6(string frL, string arL, string enL, string geL, string other, string otL);
        private event fNameFunction6 someMat6;

        public string _FreL;
        public string _AraL;
        public string _EngL;
        public string _GerL;
        public string _Other;
        public string _OthL;
        private void someOtherName6(string frL, string arL, string enL, string geL, string other, string otL)
        {
            _FreL = frL;
            _AraL = arL;
            _EngL = enL;
            _GerL = geL;
            _Other = other;
            _OthL = otL;
        }

        //UC_Software:
        public delegate void fNameFunction7(string soft1, string form1, string leve1, string soft2, string form2, string leve2, string soft3, string form3, string leve3, string soft4, string form4, string leve4);
        private event fNameFunction7 someMat7;

        public string _Soft1;
        public string _Form1;
        public string _Leve1;
        public string _Soft2;
        public string _Form2;
        public string _Leve2;
        public string _Soft3;
        public string _Form3;
        public string _Leve3;
        public string _Soft4;
        public string _Form4;
        public string _Leve4;

        private void someOtherName7(string soft1, string form1, string leve1, string soft2, string form2, string leve2, string soft3, string form3, string leve3, string soft4, string form4, string leve4)
        {
            _Soft1 = soft1;
            _Form1 = form1;
            _Leve1 = leve1;
            _Soft2 = soft2;
            _Form2 = form2;
            _Leve2 = leve2;
            _Soft3 = soft3;
            _Form3 = form3;
            _Leve3 = leve3;
            _Soft4 = soft4;
            _Form4 = form4;
            _Leve4 = leve4;
        }

        //UC_Projects:
        public delegate void fNameFunction8(string projects);
        private event fNameFunction8 someMat8;

        public string _Projects;

        private void someOtherName8(string projects)
        {
            _Projects = projects;
        }

        //UC_Intersets:
        public delegate void fNameFunction9(string inter1, string inter2, string inter3, string inter4, string inter5, string inter6, string inter7, string inter8);
        private event fNameFunction9 someMat9;

        public string _Inter1;
        public string _Inter2;
        public string _Inter3;
        public string _Inter4;
        public string _Inter5;
        public string _Inter6;
        public string _Inter7;
        public string _Inter8;

        private void someOtherName9(string inter1, string inter2, string inter3, string inter4, string inter5, string inter6, string inter7, string inter8)
        {
            _Inter1 = inter1;
            _Inter2 = inter2;
            _Inter3 = inter3;
            _Inter4 = inter4;
            _Inter5 = inter5;
            _Inter6 = inter6;
            _Inter7 = inter7;
            _Inter8 = inter8;
        }

        //UC_RequestOrigine:
        public delegate void fNameFunction10(string choice, string other);
        private event fNameFunction10 someMat10;

        public string _Choice;
        public string _Others;

        private void someOtherName10(string choice, string other)
        {
            _Choice = choice;
            _Others = other;
        }

        //UC_DoYouKnow:
        public delegate void fNameFunction11(string fName1, string name1, string job1, string fName2, string name2, string job2);
        private event fNameFunction11 someMat11;

        public string _FName1;
        public string _Name1;
        public string _Job1;
        public string _FName2;
        public string _Name2;
        public string _Job2;
        
        private void someOtherName11(string fName1, string name1, string job1, string fName2, string name2, string job2)
        {
            _FName1 = fName1;
            _Name1 = name1;
            _Job1 = job1;
            _FName2 = fName2;
            _Name2 = name2;
            _Job2 = job2;
        }

        //UC_Mdecin:
        public delegate void fNameFunction12(string med, string prof);
        private event fNameFunction12 someMat12;

        public string _Med;
        public string _Prof;

        private void someOtherName12(string med, string prof)
        {
            _Med = med;
            _Prof = prof;
        }

        //UC_ContractInfo:
        public delegate void fNameFunction13(DateTime contract, string post, string service, DateTime engage, string etat);
        private event fNameFunction13 someMat13;

        public string _ContrD;
        public string _Post;
        public string _Service;
        public string _EngageD;
        public string _Etat;

        private void someOtherName13(DateTime contract, string post, string service, DateTime engage, string etat)
        {
            _ContrD = contract.ToShortDateString();
            _Post = post;
            _Service = service;
            _EngageD = engage.ToShortDateString();
            _Etat = etat;
        }

        //UC_Rewards:
        public delegate void fNameFunction14(string salary, string iep,string autre, string panier, string transp, string saliss, string indemnite, string deplace, string danger, string phone, string penibilite, string insalubrite, string fidelite, string pri, string prc, string ppi, string iq, string mission, string ifri);
        private event fNameFunction14 someMat14;

        public string _Salary;
        public string _IEP;
        public string _Autre;
        public string _Panier;
        public string _Trans;
        public string _Saliss;
        public string _Indemn;
        public string _Deplace;
        public string _Danger;
        public string _TPhone;
        public string _Penib;
        public string _Insalub;
        public string _Fidel;
        public string _PRI;
        public string _PRC;
        public string _PPI;
        public string _IQ;
        public string _Mission;
        public string _IFRI;

        private void someOtherName14(string salary, string iep, string autre, string panier, string transp, string saliss, string indemnite, string deplace, string danger, string phone, string penibilite, string insalubrite, string fidelite, string pri, string prc, string ppi, string iq, string mission, string ifri)
        {
            _Salary = salary;
            _IEP = iep;
            _Panier = panier;
            _Trans = transp;
            _Saliss = saliss;
            _Indemn = indemnite;
            _Deplace = deplace;
            _Danger = danger;
            _TPhone = phone;
            _Penib = penibilite;
            _Insalub = insalubrite;
            _Fidel = fidelite;
            _PRI = pri;
            _PRC = prc;
            _PPI = ppi;
            _IQ = iq;
            _Mission = mission;
            _IFRI = ifri;
        }

        //UC_TrialPeriod:
        public delegate void fNameFunction15(string choice, DateTime notification, string reference);
        private event fNameFunction15 someMat15;

        public string _TriChoice;
        public string _NotifDate;
        public string _Ref;

        private void someOtherName15(string choice, DateTime notification, string reference)
        {
            _TriChoice = choice;
            _NotifDate = notification.ToShortDateString();
            _Ref = reference;
        }

        //UC_FormationCSC:
        public delegate void fNameFunction16(string exer1, string theme1, string fPlace1, string fPeriod1, DateTime fDate1, string objectif1, string exer2, string theme2, string fPlace2, string fPeriod2, DateTime fDate2, string objectif2, string exer3, string theme3, string fPlace3, string fPeriod3, DateTime fDate3, string objectif3, string exer4, string theme4, string fPlace4, string fPeriod4, DateTime fDate4, string objectif4, string exer5, string theme5, string fPlace5, string fPeriod5, DateTime fDate5, string objectif5);
        private event fNameFunction16 someMat16;

        public string _Exer1;
        public string _Theme1;
        public string _FPlace1;
        public string _FPeriod1;
        public string _FDate1;
        public string _Object1; 
        public string _Exer2;
        public string _Theme2;
        public string _FPlace2;
        public string _FPeriod2;
        public string _FDate2;
        public string _Object2;
        public string _Exer3;
        public string _Theme3;
        public string _FPlace3;
        public string _FPeriod3;
        public string _FDate3;
        public string _Object3;
        public string _Exer4;
        public string _Theme4;
        public string _FPlace4;
        public string _FPeriod4;
        public string _FDate4;
        public string _Object4;
        public string _Exer5;
        public string _Theme5;
        public string _FPlace5;
        public string _FPeriod5;
        public string _FDate5;
        public string _Object5;

        private void someOtherName16(string exer1, string theme1, string fPlace1, string fPeriod1, DateTime fDate1, string objectif1, string exer2, string theme2, string fPlace2, string fPeriod2, DateTime fDate2, string objectif2, string exer3, string theme3, string fPlace3, string fPeriod3, DateTime fDate3, string objectif3, string exer4, string theme4, string fPlace4, string fPeriod4, DateTime fDate4, string objectif4, string exer5, string theme5, string fPlace5, string fPeriod5, DateTime fDate5, string objectif5)
        {
            _Exer1 = exer1;
            _Theme1 = theme1;
            _FPlace1 = fPlace1;
            _FPeriod1 = fPeriod1;
            _FDate1 = fDate1.ToShortDateString();
            _Object1 = objectif1;
            _Exer2 = exer2;
            _Theme2 = theme2;
            _FPlace2 = fPlace2;
            _FPeriod2 = fPeriod2;
            _FDate2 = fDate2.ToShortDateString();
            _Object2 = objectif2;
            _Exer3 = exer3;
            _Theme3 = theme3;
            _FPlace3 = fPlace3;
            _FPeriod3 = fPeriod3;
            _FDate3 = fDate3.ToShortDateString();
            _Object3 = objectif3;
            _Exer4 = exer4;
            _Theme4 = theme4;
            _FPlace4 = fPlace4;
            _FPeriod4 = fPeriod4;
            _FDate4 = fDate4.ToShortDateString();
            _Object4 = objectif4;
            _Exer5 = exer5;
            _Theme5 = theme5;
            _FPlace5 = fPlace5;
            _FPeriod5 = fPeriod5;
            _FDate5 = fDate5.ToShortDateString();
            _Object5 = objectif5;
        }

        //UC_Discipline:
        public delegate void fNameFunction17(string qual1, string sanc1, DateTime sDate1, string motif1, string observ1, string qual2, string sanc2, DateTime sDate2, string motif2, string observ2, string qual3, string sanc3, DateTime sDate3, string motif3, string observ3, string qual4, string sanc4, DateTime sDate4, string motif4, string observ4);
        private event fNameFunction17 someMat17;

        public string _Qualif1;
        public string _Sanction1;
        public string _SanDate1;
        public string _Motif1;
        public string _Observ1; 
        public string _Qualif2;
        public string _Sanction2;
        public string _SanDate2;
        public string _Motif2;
        public string _Observ2;
        public string _Qualif3;
        public string _Sanction3;
        public string _SanDate3;
        public string _Motif3;
        public string _Observ3;
        public string _Qualif4;
        public string _Sanction4;
        public string _SanDate4;
        public string _Motif4;
        public string _Observ4;

        private void someOtherName17(string qual1, string sanc1, DateTime sDate1, string motif1, string observ1, string qual2, string sanc2, DateTime sDate2, string motif2, string observ2, string qual3, string sanc3, DateTime sDate3, string motif3, string observ3, string qual4, string sanc4, DateTime sDate4, string motif4, string observ4)
        {
            _Qualif1 = qual1;
            _Sanction1 = sanc1;
            _SanDate1 = sDate1.ToShortDateString();
            _Motif1 = motif1;
            _Observ1 = observ1;
            _Qualif2 = qual2;
            _Sanction2 = sanc2;
            _SanDate2 = sDate2.ToShortDateString();
            _Motif2 = motif2;
            _Observ2 = observ2;
            _Qualif3 = qual3;
            _Sanction3 = sanc3;
            _SanDate3 = sDate3.ToShortDateString();
            _Motif3 = motif3;
            _Observ3 = observ3;
            _Qualif4 = qual4;
            _Sanction4 = sanc4;
            _SanDate4 = sDate4.ToShortDateString();
            _Motif4 = motif4;
            _Observ4 = observ4;
        }

        //UC_Surveillance:
        public delegate void fNameFunction18(string stepChoice, DateTime survDate1, string stp1, string technic1, string note1, string remark1, DateTime survDate2, string stp2, string technic2, string note2, string remark2, DateTime survDate3, string stp3, string technic3, string note3, string remark3, DateTime survDate4, string stp4, string technic4, string note4, string remark4, DateTime survDate5, string stp5, string technic5, string note5, string remark5, DateTime survDate6, string stp6, string technic6, string note6, string remark6, DateTime survDate7, string stp7, string technic7, string note7, string remark7);
        private event fNameFunction18 someMat18;

        public string _StpChoice;
        public string _SurDate1;
        public string _Step1;
        public string _Technic1;
        public string _Note1;
        public string _Remark1;
        public string _SurDate2;
        public string _Step2;
        public string _Technic2;
        public string _Note2;
        public string _Remark2;
        public string _SurDate3;
        public string _Step3;
        public string _Technic3;
        public string _Note3;
        public string _Remark3;
        public string _SurDate4;
        public string _Step4;
        public string _Technic4;
        public string _Note4;
        public string _Remark4;
        public string _SurDate5;
        public string _Step5;
        public string _Technic5;
        public string _Note5;
        public string _Remark5;
        public string _SurDate6;
        public string _Step6;
        public string _Technic6;
        public string _Note6;
        public string _Remark6;
        public string _SurDate7;
        public string _Step7;
        public string _Technic7;
        public string _Note7;
        public string _Remark7;

        private void someOtherName18(string stepChoice, DateTime survDate1, string stp1, string technic1, string note1, string remark1, DateTime survDate2, string stp2, string technic2, string note2, string remark2, DateTime survDate3, string stp3, string technic3, string note3, string remark3, DateTime survDate4, string stp4, string technic4, string note4, string remark4, DateTime survDate5, string stp5, string technic5, string note5, string remark5, DateTime survDate6, string stp6, string technic6, string note6, string remark6, DateTime survDate7, string stp7, string technic7, string note7, string remark7)
        {
            _StpChoice = stepChoice;
            _SurDate1 = survDate1.ToShortDateString();
            _Step1 = stp1;
            _Technic1 = technic1;
            _Note1 = note1;
            _Remark1 = remark1;
            _SurDate2 = survDate2.ToShortDateString();
            _Step2 = stp2;
            _Technic2 = technic2;
            _Note2 = note2;
            _Remark2 = remark2;
            _SurDate3 = survDate3.ToShortDateString();
            _Step3 = stp3;
            _Technic3 = technic3;
            _Note3 = note3;
            _Remark3 = remark3;
            _SurDate4 = survDate4.ToShortDateString();
            _Step4 = stp4;
            _Technic4 = technic4;
            _Note4 = note4;
            _Remark4 = remark4;
            _SurDate5 = survDate5.ToShortDateString();
            _Step5 = stp5;
            _Technic5 = technic5;
            _Note5 = note5;
            _Remark5 = remark5;
            _SurDate6 = survDate6.ToShortDateString();
            _Step6 = stp6;
            _Technic6 = technic6;
            _Note6 = note6;
            _Remark6 = remark6;
            _SurDate7 = survDate7.ToShortDateString();
            _Step7 = stp7;
            _Technic7 = technic7;
            _Note7 = note7;
            _Remark7 = remark7;
        }

        //UC_Evaluation:
        public delegate void fNameFunction19(string exer1, string noteG1, string appre1, string exer2, string noteG2, string appre2, string exer3, string noteG3, string appre3, string exer4, string noteG4, string appre4, string exer5, string noteG5, string appre5, string exer6, string noteG6, string appre6, string exer7, string noteG7, string appre7);
        private event fNameFunction19 someMat19;

        public string _EvExer1;
        public string _NoteG1;
        public string _Appr1;
        public string _EvExer2;
        public string _NoteG2;
        public string _Appr2;
        public string _EvExer3;
        public string _NoteG3;
        public string _Appr3;
        public string _EvExer4;
        public string _NoteG4;
        public string _Appr4;
        public string _EvExer5;
        public string _NoteG5;
        public string _Appr5;
        public string _EvExer6;
        public string _NoteG6;
        public string _Appr6;
        public string _EvExer7;
        public string _NoteG7;
        public string _Appr7;

        private void someOtherName19(string exer1, string noteG1, string appre1, string exer2, string noteG2, string appre2, string exer3, string noteG3, string appre3, string exer4, string noteG4, string appre4, string exer5, string noteG5, string appre5, string exer6, string noteG6, string appre6, string exer7, string noteG7, string appre7)
        {
            _EvExer1 = exer1;
            _NoteG1 = noteG1;
            _Appr1 = appre1;
            _EvExer2 = exer2;
            _NoteG2 = noteG2;
            _Appr2 = appre2;
            _EvExer3 = exer3;
            _NoteG3 = noteG3;
            _Appr3 = appre3;
            _EvExer4 = exer4;
            _NoteG4 = noteG4;
            _Appr4 = appre4;
            _EvExer5 = exer5;
            _NoteG5 = noteG5;
            _Appr5 = appre5;
            _EvExer6 = exer6;
            _NoteG6 = noteG6;
            _Appr6 = appre6;
            _EvExer7 = exer7;
            _NoteG7 = noteG7;
            _Appr7 = appre7;
        }

        //UC_Emprovement:
        public delegate void fNameFunction20(string exer1, string promo1, string reaff1, string form1, string autres1, string exer2, string promo2, string reaff2, string form2, string autres2, string exer3, string promo3, string reaff3, string form3, string autres3, string exer4, string promo4, string reaff4, string form4, string autres4, string exer5, string promo5, string reaff5, string form5, string autres5, string exer6, string promo6, string reaff6, string form6, string autres6, string exer7, string promo7, string reaff7, string form7, string autres7);
        private event fNameFunction20 someMat20;

        public string _AmExer1;
        public string _Promo1;
        public string _Reaffec1;
        public string _AmForm1;
        public string _AmAutres1;
        public string _AmExer2;
        public string _Promo2;
        public string _Reaffec2;
        public string _AmForm2;
        public string _AmAutres2;
        public string _AmExer3;
        public string _Promo3;
        public string _Reaffec3;
        public string _AmForm3;
        public string _AmAutres3;
        public string _AmExer4;
        public string _Promo4;
        public string _Reaffec4;
        public string _AmForm4;
        public string _AmAutres4;
        public string _AmExer5;
        public string _Promo5;
        public string _Reaffec5;
        public string _AmForm5;
        public string _AmAutres5;
        public string _AmExer6;
        public string _Promo6;
        public string _Reaffec6;
        public string _AmForm6;
        public string _AmAutres6;
        public string _AmExer7;
        public string _Promo7;
        public string _Reaffec7;
        public string _AmForm7;
        public string _AmAutres7;

        private void someOtherName20(string exer1, string promo1, string reaff1, string form1, string autres1, string exer2, string promo2, string reaff2, string form2, string autres2, string exer3, string promo3, string reaff3, string form3, string autres3, string exer4, string promo4, string reaff4, string form4, string autres4, string exer5, string promo5, string reaff5, string form5, string autres5, string exer6, string promo6, string reaff6, string form6, string autres6, string exer7, string promo7, string reaff7, string form7, string autres7)
        {
            _AmExer1 = exer1;
            _Promo1 = promo1;
            _Reaffec1 = reaff1;
            _AmForm1 = form1;
            _AmAutres1 = autres1;
            _AmExer2 = exer2;
            _Promo2 = promo2;
            _Reaffec2 = reaff2;
            _AmForm2 = form2;
            _AmAutres2 = autres2;
            _AmExer3 = exer3;
            _Promo3 = promo3;
            _Reaffec3 = reaff3;
            _AmForm3 = form3;
            _AmAutres3 = autres3;
            _AmExer4 = exer4;
            _Promo4 = promo4;
            _Reaffec4 = reaff4;
            _AmForm4 = form4;
            _AmAutres4 = autres4;
            _AmExer5 = exer5;
            _Promo5 = promo5;
            _Reaffec5 = reaff5;
            _AmForm5 = form5;
            _AmAutres5 = autres5;
            _AmExer6 = exer6;
            _Promo6 = promo6;
            _Reaffec6 = reaff6;
            _AmForm6 = form6;
            _AmAutres6 = autres6;
            _AmExer7 = exer7;
            _Promo7 = promo7;
            _Reaffec7 = reaff7;
            _AmForm7 = form7;
            _AmAutres7 = autres7;
        }

        //UC_EndContract:
        public delegate void fNameFunction21(string contract, DateTime conDate, DateTime notification, string reference);
        private event fNameFunction21 someMat21;

        public string _Contract;
        public string _ContDate;
        public string _ConNotif;
        public string _ConRef;

        private void someOtherName21(string contract, DateTime conDate, DateTime notification, string reference)
        {
            _Contract = contract;
            _ContDate = conDate.ToShortDateString();
            _ConNotif = notification.ToShortDateString();
            _ConRef = reference;
        }

        //Leave:
        public delegate void fNameFunction22(string cause, DateTime depDate,  string categori, string autreCause);
        private event fNameFunction22 someMat22;

        public string _deparDate;
        public string _deparCause;
        public string _deparCateg;
        public string _autreCause;

        private void someOtherName22(string cause, DateTime depDate, string categori, string autreCause)
        {
            _deparDate = depDate.ToShortDateString();
            _deparCause = cause;
            _deparCateg = categori;
            _autreCause = autreCause;
        }
        public Form_Recruit()
        {
            InitializeComponent();
           
            pnlButtons1.Visible = false;
            pnlButtons.AutoScroll = false;
            pnlButtons.HorizontalScroll.Enabled = false;
            pnlButtons1.AutoScroll = false;
            pnlButtons1.HorizontalScroll.Enabled = false;

            //AddControlsToPanel(c_Rewards);
            //AddControlsToPanel(c_CivilState);
        }

        private void movePlacePanel(Control btn)
        {
            pnlPlace.Left = btn.Left;
            pnlPlace.Width = btn.Width;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(c);
        }
        public int scrollValue = 0;
        public int ScrollValue
        {
            get
            {
                return scrollValue;
            }
            set
            {
                scrollValue = value;
                pnlButtons.HorizontalScroll.Maximum = 800;

                if (scrollValue < pnlButtons.HorizontalScroll.Minimum)
                {
                    scrollValue = pnlButtons.HorizontalScroll.Minimum;
                }
                if (scrollValue > pnlButtons.HorizontalScroll.Maximum)
                {
                    scrollValue = pnlButtons.HorizontalScroll.Maximum;
                }

                pnlButtons.HorizontalScroll.Value = scrollValue;
                pnlButtons.PerformLayout();

            }
        }

        string pnlName = "Info";
        private void btnInfo_Click(object sender, EventArgs e)
        {
            movePlacePanel(btnInfo);
            if (pnlButtons.Visible == false)
            {
                pnlButtons.Visible = true;
                pnlButtons1.Visible = false;
                pnlName = "Info";
                UserControls.UC_CivilState c_CivilState = new UserControls.UC_CivilState();
                someMat = new fNameFunction(someOtherName);
                c_CivilState.Mat = someMat;
                AddControlsToPanel(c_CivilState);
            }
        }

        private void btnRH_Click(object sender, EventArgs e)
        {
            movePlacePanel(btnRH);
            if (pnlButtons1.Visible == false)
            {
                pnlButtons1.Visible = true;
                pnlButtons.Visible = false;
                pnlName = "RH";
                UserControls.UC_Medecin c_Medecin = new UserControls.UC_Medecin();
                someMat12 = new fNameFunction12(someOtherName12);
                c_Medecin.Mat12 = someMat12;
                AddControlsToPanel(c_Medecin);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(pnlName == "Info")
            {
                 ScrollValue -= pnlButtons.HorizontalScroll.LargeChange;
            }
            else if(pnlName == "RH")
            {
                ScrollValue1 -= pnlButtons1.HorizontalScroll.LargeChange;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (pnlName == "Info")
            {
                ScrollValue += pnlButtons.HorizontalScroll.LargeChange;
            }
            else if(pnlName == "RH")
            {
                ScrollValue1 += pnlButtons1.HorizontalScroll.LargeChange;
            }
        }

        public int scrollValue1 = 0;
        public int ScrollValue1
        {
            get
            {
                return scrollValue1;
            }
            set
            {
                scrollValue1 = value;
                pnlButtons1.HorizontalScroll.Maximum = 800;

                if (scrollValue1 < pnlButtons1.HorizontalScroll.Minimum)
                {
                    scrollValue1 = pnlButtons1.HorizontalScroll.Minimum;
                }
                if (scrollValue1 > pnlButtons1.HorizontalScroll.Maximum)
                {
                    scrollValue1 = pnlButtons1.HorizontalScroll.Maximum;
                }

                pnlButtons1.HorizontalScroll.Value = scrollValue1;
                pnlButtons1.PerformLayout();

            }
        }
        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnGenInfo_Click(object sender, EventArgs e)
        {
            UserControls.UC_CivilState c_CivilState = new UserControls.UC_CivilState();
            someMat = new fNameFunction(someOtherName);
            c_CivilState.Mat = someMat;
            AddControlsToPanel(c_CivilState);
        }

        private void btnMilitary_Click(object sender, EventArgs e)
        {
            UserControls.UC_Military c_Military = new UserControls.UC_Military();
            someMat1 = new fNameFunction1(someOtherName1);
            c_Military.Mat1 = someMat1;
            AddControlsToPanel(c_Military);
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            UserControls.UC_StudyLevel c_StudyLevel = new UserControls.UC_StudyLevel();
            someMat2 = new fNameFunction2(someOtherName2);
            c_StudyLevel.Mat2 = someMat2;
            AddControlsToPanel(c_StudyLevel);
        }

        private void btnEP_Click(object sender, EventArgs e)
        {
            UserControls.UC_ProfStudy c_ProfStudy = new UserControls.UC_ProfStudy();
            someMat3 = new fNameFunction3(someOtherName3);
            c_ProfStudy.Mat3 = someMat3;
            AddControlsToPanel(c_ProfStudy);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            UserControls.UC_Trainings c_Trainings = new UserControls.UC_Trainings();
            someMat4 = new fNameFunction4(someOtherName4);
            c_Trainings.Mat4 = someMat4;
            AddControlsToPanel(c_Trainings);
        }

        private void btnCareer_Click(object sender, EventArgs e)
        {
            UserControls.UC_Career c_Career = new UserControls.UC_Career();
            someMat5 = new fNameFunction5(someOtherName5);
            c_Career.Mat5 = someMat5;
            AddControlsToPanel(c_Career);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            UserControls.UC_Language c_Language = new UserControls.UC_Language();
            someMat6 = new fNameFunction6(someOtherName6);
            c_Language.Mat6 = someMat6;
            AddControlsToPanel(c_Language);
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            UserControls.UC_Software c_Software = new UserControls.UC_Software();
            someMat7 = new fNameFunction7(someOtherName7);
            c_Software.Mat7 = someMat7;
            AddControlsToPanel(c_Software);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            UserControls.UC_Projects c_Projects = new UserControls.UC_Projects();
            someMat8 = new fNameFunction8(someOtherName8);
            c_Projects.Mat8 = someMat8;
            AddControlsToPanel(c_Projects);
        }

        private void btnInterst_Click(object sender, EventArgs e)
        {
            UserControls.UC_Intersets c_Intersets = new UserControls.UC_Intersets();
            someMat9 = new fNameFunction9(someOtherName9);
            c_Intersets.Mat9 = someMat9;
            AddControlsToPanel(c_Intersets);
        }

        private void btnOrigine_Click(object sender, EventArgs e)
        {
            UserControls.UC_RequestOrigine c_RequestOrigine = new UserControls.UC_RequestOrigine();
            someMat10 = new fNameFunction10(someOtherName10);
            c_RequestOrigine.Mat10 = someMat10;
            AddControlsToPanel(c_RequestOrigine);
        }

        private void btnKnows_Click(object sender, EventArgs e)
        {
            UserControls.UC_DoYouKnow c_DoYouKnow = new UserControls.UC_DoYouKnow();
            someMat11 = new fNameFunction11(someOtherName11);
            c_DoYouKnow.Mat11 = someMat11;
            AddControlsToPanel(c_DoYouKnow);
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            UserControls.UC_Medecin c_Medecin = new UserControls.UC_Medecin();
            someMat12 = new fNameFunction12(someOtherName12);
            c_Medecin.Mat12 = someMat12;
            AddControlsToPanel(c_Medecin);
        }

        private void NtnContract_Click(object sender, EventArgs e)
        {
            UserControls.UC_ContractInfo c_ContractInfo = new UserControls.UC_ContractInfo();
            someMat13 = new fNameFunction13(someOtherName13);
            c_ContractInfo.Mat13 = someMat13;
            AddControlsToPanel(c_ContractInfo);
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            UserControls.UC_Rewards c_Rewards = new UserControls.UC_Rewards();
            someMat14 = new fNameFunction14(someOtherName14);
            c_Rewards.Mat14 = someMat14;
            AddControlsToPanel(c_Rewards);
        }

        private void btnAppreciate_Click(object sender, EventArgs e)
        {
            UserControls.UC_TrialPeriod c_TrialPeriod = new UserControls.UC_TrialPeriod();
            someMat15 = new fNameFunction15(someOtherName15);
            c_TrialPeriod.Mat15 = someMat15;
            AddControlsToPanel(c_TrialPeriod);
        }

        private void btnFormation_Click(object sender, EventArgs e)
        {
            UserControls.UC_FormationCSC c_FormationCSC = new UserControls.UC_FormationCSC();
            someMat16 = new fNameFunction16(someOtherName16);
            c_FormationCSC.Mat16 = someMat16;
            AddControlsToPanel(c_FormationCSC);
        }

        private void btnDiscipline_Click(object sender, EventArgs e)
        {
            UserControls.UC_Discipline c_Discipline = new UserControls.UC_Discipline();
            someMat17 = new fNameFunction17(someOtherName17);
            c_Discipline.Mat17 = someMat17;
            AddControlsToPanel(c_Discipline);
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            UserControls.UC_Surveillance c_Surveillance = new UserControls.UC_Surveillance();
            someMat18 = new fNameFunction18(someOtherName18);
            c_Surveillance.Mat18 = someMat18;
            AddControlsToPanel(c_Surveillance);
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            UserControls.UC_Evaluation c_Evaluation = new UserControls.UC_Evaluation();
            someMat19 = new fNameFunction19(someOtherName19);
            c_Evaluation.Mat19 = someMat19;
            AddControlsToPanel(c_Evaluation);
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            UserControls.UC_Emprovement c_Emprovement = new UserControls.UC_Emprovement();
            someMat20 = new fNameFunction20(someOtherName20);
            c_Emprovement.Mat20 = someMat20;
            AddControlsToPanel(c_Emprovement);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserControls.UC_EndContract c_EndContract = new UserControls.UC_EndContract();
            someMat21 = new fNameFunction21(someOtherName21);
            c_EndContract.Mat21 = someMat21;
            AddControlsToPanel(c_EndContract);
        }

        int page = 1;

        UC_CivilState c_CS = new UC_CivilState();
        //MyUserControlName.MyUserControlPropertyName = "A string";
        
        UC_Military c_M = new UC_Military();
        UC_StudyLevel c_SL = new UC_StudyLevel();

        string userName = Settings.Default.userName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            if (page == 1)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" Fiche de Renseignement & carrière ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(280, 90));
                
                e.Graphics.DrawString(" 1.Etat civil: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                e.Graphics.DrawString(" Matricule: " + _Mat, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));
                e.Graphics.DrawString(" Nom: " + _LName + "    Prénom: " + _Name + "    Nom De Jeune Fille: " + _NameBefo, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                e.Graphics.DrawString(" Né(e) le: " + _BirthD + "    à " + _BirthP, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 190));
                e.Graphics.DrawString(" Situation de Famille: " + _FamSit, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 210));
                e.Graphics.DrawString(" Nationalité: " + _Nation, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                e.Graphics.DrawString(" Adresse: " + _Adress, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                e.Graphics.DrawString(" N° Tél: " + _Phone, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 270));
                e.Graphics.DrawString(" Prénom de Père: " + _FathName + "    Nom et Prénom de la Mère: " + _MothFullName, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 290));
                e.Graphics.DrawString(" Groupe sanguin: " + _BloodType, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" Profession des Parents: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 330));
                e.Graphics.DrawString("   *Père: " + _FathJob + "    *Mère: " + _MothFullName, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                e.Graphics.DrawString(" Nombres de Frères & Soeurs: " + _SiblingNum, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 370));
                e.Graphics.DrawString(" Nom et Prénom du Conjoint: " + _MariName, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 390));
                e.Graphics.DrawString(" Profession du Conjoint: " + _MariJob, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                e.Graphics.DrawString(" N°Compte Bancaire: " + _AccountNum, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                e.Graphics.DrawString(" N°Sécurité Sociale: " + _SecuNum, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                e.Graphics.DrawString(" Carte Nationale N°: " + _CarteNum + "       Délivrée par: " + _DeliverBy + "       Le: " + _DeliverDate, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 470));
                
                e.Graphics.DrawString(" 2.Situation vis a vis du service national: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 500));
                if (_Engage == "OUI")
                {
                    e.Graphics.DrawString(" Dégagé: OUI", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                else if (_Engage == "NON")
                {
                    e.Graphics.DrawString(" Dégagé: NON", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                else
                {
                    e.Graphics.DrawString(" Dégagé: OUI [  ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                e.Graphics.DrawString(" Date d'immobilisation: " + _ImmoDate, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                e.Graphics.DrawString(" Sursitaire: Du: " + _SursiFrom + "    Au: " + _SursiTo, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 570));
                if (_Apte == "OUI")
                {
                    e.Graphics.DrawString(" Apte non incorporale: OUI", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 590));
                }
                else if (_Apte == "NON")
                {
                    e.Graphics.DrawString(" Apte non incorporale: NON", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 590));
                }
                else
                {
                    e.Graphics.DrawString(" Apte non incorporale: OUI [  ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 590));
                }

                e.Graphics.DrawString(" 3.Niveau scolaire et universitaire: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 620));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 650));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 665));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 680));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 681));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 696));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 711));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 712));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 727));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 742));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 743));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 758));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 773));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 774));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 789));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 804));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 805));
                e.Graphics.DrawString("  " + _Etab1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 706));
                e.Graphics.DrawString("  " + _Speci1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 706));
                e.Graphics.DrawString("  " + _Period1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 706));
                e.Graphics.DrawString("  " + _Dipl1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 706));
                e.Graphics.DrawString("  " + _ObtDate1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 706));

                e.Graphics.DrawString("  " + _Etab2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 737));
                e.Graphics.DrawString("  " + _Speci2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 737));
                e.Graphics.DrawString("  " + _Period2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 737));
                e.Graphics.DrawString("  " + _Dipl2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 737));
                e.Graphics.DrawString("  " + _ObtDate2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 737));

                e.Graphics.DrawString("  " + _Etab3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 768));
                e.Graphics.DrawString("  " + _Speci3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 768));
                e.Graphics.DrawString("  " + _Period3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 768));
                e.Graphics.DrawString("  " + _Dipl3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 768));
                e.Graphics.DrawString("  " + _ObtDate3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 768));

                e.Graphics.DrawString("  " + _Etab4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 799));
                e.Graphics.DrawString("  " + _Speci4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 799));
                e.Graphics.DrawString("  " + _Period4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 799));
                e.Graphics.DrawString("  " + _Dipl4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 799));
                e.Graphics.DrawString("  " + _ObtDate4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 799));

                e.Graphics.DrawString(" 4.Enseignement professionnel: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(90, 835));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 865));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 880));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 895));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 896));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 911));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 926));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 927));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 942));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 957));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 958));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 973));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 988));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 989));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1004));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1019));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1020));
                e.Graphics.DrawString("  " + _Etabl1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 921));
                e.Graphics.DrawString("  " + _Spec1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 921));
                e.Graphics.DrawString("  " + _Perio1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 921));
                e.Graphics.DrawString("  " + _Dip1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 921));
                e.Graphics.DrawString("  " + _ObtenDate1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 921));

                e.Graphics.DrawString("  " + _Etabl2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 952));
                e.Graphics.DrawString("  " + _Spec2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 952));
                e.Graphics.DrawString("  " + _Perio2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 952));
                e.Graphics.DrawString("  " + _Dip2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 952));
                e.Graphics.DrawString("  " + _ObtenDate2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 952));

                e.Graphics.DrawString("  " + _Etabl3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 983));
                e.Graphics.DrawString("  " + _Spec3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 983));
                e.Graphics.DrawString("  " + _Perio3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 983));
                e.Graphics.DrawString("  " + _Dip3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 983));
                e.Graphics.DrawString("  " + _ObtenDate3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 983));

                e.Graphics.DrawString("  " + _Etabl4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 1014));
                e.Graphics.DrawString("  " + _Spec4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 1014));
                e.Graphics.DrawString("  " + _Perio4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 1014));
                e.Graphics.DrawString("  " + _Dip4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 1014));
                e.Graphics.DrawString("  " + _ObtenDate4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 1014));

                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 675));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 675));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 675));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 675));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 675));

                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 890));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 890));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 890));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 890));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 890));

                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 2)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 5.Stages effectues: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 120));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 135));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 150));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 151));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 166));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 181));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 182));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 197));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 212));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 213));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 228));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 243));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 244));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 259));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 274));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 275));

                e.Graphics.DrawString("  " + _E1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 176));
                e.Graphics.DrawString("  " + _S1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 176));
                e.Graphics.DrawString("  " + _P1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 176));
                e.Graphics.DrawString("  " + _D1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 176));
                e.Graphics.DrawString("  " + _O1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 176));

                e.Graphics.DrawString("  " + _E2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 207));
                e.Graphics.DrawString("  " + _S2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 207));
                e.Graphics.DrawString("  " + _P2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 207));
                e.Graphics.DrawString("  " + _D2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 207));
                e.Graphics.DrawString("  " + _O2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 207));

                e.Graphics.DrawString("  " + _E3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 238));
                e.Graphics.DrawString("  " + _S3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 238));
                e.Graphics.DrawString("  " + _P3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 238));
                e.Graphics.DrawString("  " + _D3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 238));
                e.Graphics.DrawString("  " + _O3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 238));

                e.Graphics.DrawString("  " + _E4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 269));
                e.Graphics.DrawString("  " + _S4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 269));
                e.Graphics.DrawString("  " + _P4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 269));
                e.Graphics.DrawString("  " + _D4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(495, 269));
                e.Graphics.DrawString("  " + _O4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(655, 269));

                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 145));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 145));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 145));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 145));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 145));

                e.Graphics.DrawString(" 6.Carrière professionnelle: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 305));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 335));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 350));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 365));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 366));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 381));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 396));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 397));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 412));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 427));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 428));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 443));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 458));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 459));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 474));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 489));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 490));

                e.Graphics.DrawString("  " + _Emp1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 391));
                e.Graphics.DrawString("  " + _Work1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(270, 391));
                e.Graphics.DrawString("  " + _From1 + "  " + _To1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 391));
                e.Graphics.DrawString("  " + _Motive1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(575, 391));

                e.Graphics.DrawString("  " + _Emp2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 422));
                e.Graphics.DrawString("  " + _Work2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(270, 422));
                e.Graphics.DrawString("  " + _From2 + "  " + _To1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 422));
                e.Graphics.DrawString("  " + _Motive2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(575, 422));

                e.Graphics.DrawString("  " + _Emp3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 453));
                e.Graphics.DrawString("  " + _Work3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(270, 453));
                e.Graphics.DrawString("  " + _From3 + "  " + _To1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 453));
                e.Graphics.DrawString("  " + _Motive3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(575, 453));

                e.Graphics.DrawString("  " + _Emp4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 484));
                e.Graphics.DrawString("  " + _Work4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(270, 484));
                e.Graphics.DrawString("  " + _From4 + "  " + _To1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 484));
                e.Graphics.DrawString("  " + _Motive4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(575, 484));

                e.Graphics.DrawString(" Employeur ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(130, 360));
                e.Graphics.DrawString(" Emploi ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(320, 360));
                e.Graphics.DrawString(" Du:     Au: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(450, 360));
                e.Graphics.DrawString(" Motif du départ ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(610, 360));

                e.Graphics.DrawString(" 7.Langues: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 520));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 565));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 580));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 581));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 596));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 611));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 612));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 627));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 642));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 643));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 658));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 673));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 674));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 689));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 704));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 705));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 720));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 735));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 750));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 751));
                if (_FreL == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(305, 606));
                }
                else if (_FreL == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 606));
                }
                else if (_FreL == "Moyen+")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 606));
                }
                else if (_FreL == "Moyen-")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(595, 606));
                }
                else if (_FreL == "Néant")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 606));
                }
                if (_AraL == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(305, 637));
                }
                else if (_AraL == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 637));
                }
                else if (_AraL == "Moyen+")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 637));
                }
                else if (_AraL == "Moyen-")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(595, 637));
                }
                else if (_AraL == "Néant")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 637));
                }
                if (_EngL == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(305, 668));
                }
                else if (_EngL == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 668));
                }
                else if (_EngL == "Moyen+")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 668));
                }
                else if (_EngL == "Moyen-")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(595, 668));
                }
                else if (_EngL == "Néant")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 668));
                }
                if (_GerL == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(305, 699));
                }
                else if (_GerL == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 699));
                }
                else if (_GerL == "Moyen+")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 699));
                }
                else if (_GerL == "Moyen-")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(595, 699));
                }
                else if (_GerL == "Néant")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 699));
                }
                if (_OthL == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(305, 730));
                }
                else if (_OthL == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 730));
                }
                else if (_OthL == "Moyen+")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 730));
                }
                else if (_OthL == "Moyen-")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(595, 730));
                }
                else if (_OthL == "Néant")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 730));
                }
                e.Graphics.DrawString(" Langues ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 575));
                e.Graphics.DrawString(" Nature ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(190, 575));
                e.Graphics.DrawString(" T.Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(290, 575));
                e.Graphics.DrawString(" Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(390, 575));
                e.Graphics.DrawString(" Moyen(+) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(475, 575));
                e.Graphics.DrawString(" Moyen(-) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(575, 575));
                e.Graphics.DrawString(" Néant ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 575));

                e.Graphics.DrawString(" Français ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 606));
                e.Graphics.DrawString(" Arabe ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 637));
                e.Graphics.DrawString(" Anglais ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 668));
                e.Graphics.DrawString(" Allemand ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 699));
                e.Graphics.DrawString(" Autre\n " + _Other, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 725));

                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 598));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 629));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 660));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 691));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 722));

                e.Graphics.DrawString(" 8.Maitrise de logiciels informatique: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 781));
                e.Graphics.DrawString(" _______________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(385, 811));
                e.Graphics.DrawString("                                                                   |                                                                               |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 826));
                e.Graphics.DrawString("                                                                   |                                                                               |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 841));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 842));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 857));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 872));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 887));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 888));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 903));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 918));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 919));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 934));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 949));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 950));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 965));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 980));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 981));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 996));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1011));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1012));
                e.Graphics.DrawString(" " + _Soft1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(80, 913));
                if (_Form1 == "Avec formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(225, 913));
                }
                else if (_Form1 == "Sans formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(325, 913));
                }
                if (_Leve1 == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 913));
                }
                else if (_Leve1 == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(510, 913));
                }
                else if (_Leve1 == "Moyen")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 913));
                }
                else if (_Leve1 == "Initiation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 913));
                }
                e.Graphics.DrawString(" " + _Soft2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(80, 944));
                if (_Form2 == "Avec formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(225, 944));
                }
                else if (_Form2 == "Sans formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(325, 944));
                }
                if (_Leve2 == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 944));
                }
                else if (_Leve2 == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(510, 944));
                }
                else if (_Leve2 == "Moyen")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 944));
                }
                else if (_Leve2 == "Initiation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 944));
                }
                e.Graphics.DrawString(" " + _Soft3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(80, 975));
                if (_Form3 == "Avec formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(225, 975));
                }
                else if (_Form3 == "Sans formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(325, 975));
                }
                if (_Leve3 == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 975));
                }
                else if (_Leve3 == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(510, 975));
                }
                else if (_Leve3 == "Moyen")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 975));
                }
                else if (_Leve3 == "Initiation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 975));
                }
                e.Graphics.DrawString(" " + _Soft4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(80, 1006));
                if (_Form4 == "Avec formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(225, 1006));
                }
                else if (_Form4 == "Sans formation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(325, 1006));
                }
                if (_Leve4 == "T.Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 1006));
                }
                else if (_Leve4 == "Bien")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(510, 1006));
                }
                else if (_Leve4 == "Moyen")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 1006));
                }
                else if (_Leve4 == "Initiation")
                {
                    e.Graphics.DrawString(" + ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(695, 1006));
                }
                e.Graphics.DrawString(" Pondération ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(525, 830));
                e.Graphics.DrawString(" Logiciels ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 867));
                e.Graphics.DrawString("   Avec\nformation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(205, 867));
                e.Graphics.DrawString("   Sans\nformation", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(305, 867));
                e.Graphics.DrawString(" T.Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(405, 867));
                e.Graphics.DrawString(" Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(502, 867));
                e.Graphics.DrawString(" Moyen ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(588, 867));
                e.Graphics.DrawString(" Initiation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(673, 867));

                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            //page++;
            if (page == 3)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 9.Travaux particuliers réalises: (études, projets, ...etc.)", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 120));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 135));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 150));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 165));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 180));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 195));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 210));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 225));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 240));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 255));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 270));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 285));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 300));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 315));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 330));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 345));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 360));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 361));
                

                Rectangle rec = new Rectangle(78, 137, 675,240);
                e.Graphics.FillRectangle(Brushes.Transparent, rec);
                e.Graphics.DrawString(" " + _Projects, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, rec);

                e.Graphics.DrawString(" 10.Centres d'intéret: (Lecture, Sport, Musique, Loisirs ...) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 391));
                e.Graphics.DrawString(" Citez vos centres d'intéret par ordre de priorité. ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 411));
                e.Graphics.DrawString(" 1. " + _Inter1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 441));
                e.Graphics.DrawString(" 3. " + _Inter3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 461));
                e.Graphics.DrawString(" 5. " + _Inter5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 481));
                e.Graphics.DrawString(" 7. " + _Inter7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 501));
                e.Graphics.DrawString(" 2. " + _Inter2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(410, 441));
                e.Graphics.DrawString(" 4. " + _Inter4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(410, 461));
                e.Graphics.DrawString(" 6. " + _Inter6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(410, 481));
                e.Graphics.DrawString(" 8. " + _Inter8, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(410, 501));

                e.Graphics.DrawString(" 11.Origine de votre demande de recrutement suite a: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 531));
                if (_Choice == "1stChoice")
                {
                    e.Graphics.DrawString(" * Avis de recrutement paru par voie de presse            [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 561));
                    e.Graphics.DrawString(" * Recommondation par le bureau de main d'oeuvre    [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 581));
                    e.Graphics.DrawString(" * Recommondation par un travailleur de CSC             [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 601));
                    e.Graphics.DrawString(" * Autre:     " + _Others, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 621));
                }
                else if (_Choice == "2ndChoice")
                {
                    e.Graphics.DrawString(" * Avis de recrutement paru par voie de presse            [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 561));
                    e.Graphics.DrawString(" * Recommondation par le bureau de main d'oeuvre    [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 581));
                    e.Graphics.DrawString(" * Recommondation par un travailleur de CSC             [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 601));
                    e.Graphics.DrawString(" * Autre:     " + _Others, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 621));
                }
                else if (_Choice == "3rdChoice")
                {
                    e.Graphics.DrawString(" * Avis de recrutement paru par voie de presse            [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 561));
                    e.Graphics.DrawString(" * Recommondation par le bureau de main d'oeuvre    [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 581));
                    e.Graphics.DrawString(" * Recommondation par un travailleur de CSC             [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 601));
                    e.Graphics.DrawString(" * Autre:     " + _Others, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 621));
                }
                else
                {
                    e.Graphics.DrawString(" * Avis de recrutement paru par voie de presse            [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 561));
                    e.Graphics.DrawString(" * Recommondation par le bureau de main d'oeuvre    [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 581));
                    e.Graphics.DrawString(" * Recommondation par un travailleur de CSC             [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 601));
                    e.Graphics.DrawString(" * Autre:     " + _Others, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 621));
                }
                e.Graphics.DrawString(" 12.Connaissez-vous des personnes au niveau de CSC? Si oui, lesquelles? ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 651));
                e.Graphics.DrawString(" Noms ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 681));
                e.Graphics.DrawString(" Prénoms ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(380, 681));
                e.Graphics.DrawString(" Fontions ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 681));

                e.Graphics.DrawString(" * " + _FName1  + "\n * " + _FName2 + "\n * " + _Job1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 701));
                e.Graphics.DrawString(" * " + _Name1 + "\n * " + _Name2 + "\n * " + _Job2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(310, 701));
                //e.Graphics.DrawString(" *\n *\n * ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(530, 701));
                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 4)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" PARTIE A REMPLIR PAR RH: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 90));
                e.Graphics.DrawString(" 13.Médicine de travail: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                if (_Med == "Concluant")
                {
                    e.Graphics.DrawString(" Test cocluant: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));
                    e.Graphics.DrawString(" Test non cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                }
                else if (_Med == "Non Concluant")
                {
                    e.Graphics.DrawString(" Test cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));
                    e.Graphics.DrawString(" Test non cocluant: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                }
                else 
                {
                    e.Graphics.DrawString(" Test cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));
                    e.Graphics.DrawString(" Test non cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                }

                e.Graphics.DrawString(" 14.Test professionnel: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 200));
                if (_Prof == "Concluant")
                {
                    e.Graphics.DrawString(" Test cocluant: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                    e.Graphics.DrawString(" Test non cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                }
                else if (_Prof == "Non Concluant")
                {
                    e.Graphics.DrawString(" Test cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                    e.Graphics.DrawString(" Test non cocluant: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                }
                else 
                {
                    e.Graphics.DrawString(" Test cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                    e.Graphics.DrawString(" Test non cocluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                }

                e.Graphics.DrawString(" 15.Contrat: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 280));
                e.Graphics.DrawString(" Contrat de travail: établi le " + _ContrD + "      Fonction: " + _Post + "       Etat:" + _Etat, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" Direction/Service/Projet: " + _Service + "      Date d'engagement: " + _EngageD, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 330));

                e.Graphics.DrawString(" 16.Primes et Indemnités: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 360));

                e.Graphics.DrawString(" Salaire de base: " + _Salary + "      IEP: " + _IEP, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 390));
                if (_Panier == "Yes")
                {
                    e.Graphics.DrawString(" Panier: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(440, 390));
                }
                else if (_Panier == "No")
                {
                    e.Graphics.DrawString(" Panier: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(440, 390));
                }
                else
                {
                    e.Graphics.DrawString(" Panier: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(440, 390));
                }
                if (_Trans == "Yes")
                {
                    e.Graphics.DrawString(" Transport: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(540, 390));
                }
                else if (_Trans == "No")
                {
                    e.Graphics.DrawString(" Transport: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(540, 390));
                }
                else
                {
                    e.Graphics.DrawString(" Transport: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(540, 390));
                }
                if (_Saliss == "Yes")
                {
                    e.Graphics.DrawString(" Salissure: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(670, 390));
                }
                else if (_Saliss == "No")
                {
                    e.Graphics.DrawString(" Salissure: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(670, 390));
                }
                else
                {
                    e.Graphics.DrawString(" Salissure: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(670, 390));
                }
                if (_Indemn == "Yes")
                {
                    e.Graphics.DrawString(" Indemnité Véhicule: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                }
                else if (_Indemn == "No")
                {
                    e.Graphics.DrawString(" Indemnité Véhicule: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                }
                else
                {
                    e.Graphics.DrawString(" Indemnité Véhicule: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                }
                if (_Deplace == "Yes")
                {
                    e.Graphics.DrawString(" Frais de déplacement: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 410));
                }
                else if (_Deplace == "No")
                {
                    e.Graphics.DrawString(" Frais de déplacement: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 410));
                }
                else
                {
                    e.Graphics.DrawString(" Frais de déplacement: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 410));
                }
                if (_Danger == "Yes")
                {
                    e.Graphics.DrawString(" Danger: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(457, 410));
                }
                else if (_Danger == "No")
                {
                    e.Graphics.DrawString(" Danger: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(457, 410));
                }
                else
                {
                    e.Graphics.DrawString(" Danger: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(457, 410));
                }
                if (_TPhone == "Yes")
                {
                    e.Graphics.DrawString(" Téléphone: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(565, 410));
                }
                else if (_TPhone == "No")
                {
                    e.Graphics.DrawString(" Téléphone: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(565, 410));
                }
                else
                {
                    e.Graphics.DrawString(" Téléphone: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(565, 410));
                }
                if (_Penib == "Yes")
                {
                    e.Graphics.DrawString(" Pénibilité: [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(695, 410));
                }
                else if (_Penib == "No")
                {
                    e.Graphics.DrawString(" Pénibilité: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(695, 410));
                }
                else
                {
                    e.Graphics.DrawString(" Pénibilité: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(695, 410));
                }
                if (_Insalub == "Yes")
                {
                    e.Graphics.DrawString(" Insalubrité: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                }
                else if (_Insalub == "No")
                {
                    e.Graphics.DrawString(" Insalubrité: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                }
                else
                {
                    e.Graphics.DrawString(" Insalubrité: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                }
                if (_Fidel == "Yes")
                {
                    e.Graphics.DrawString(" Fidélité: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(195, 430));
                }
                else if (_Fidel == "No")
                {
                    e.Graphics.DrawString(" Fidélité: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(195, 430));
                }
                else
                {
                    e.Graphics.DrawString(" Fidélité: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(195, 430));
                }
                if (_PRI == "Yes")
                {
                    e.Graphics.DrawString(" PRI: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(298, 430));
                }
                else if (_PRI == "No")
                {
                    e.Graphics.DrawString(" PRI: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(298, 430));
                }
                else
                {
                    e.Graphics.DrawString(" PRI: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(298, 430));
                }
                if (_PRC == "Yes")
                {
                    e.Graphics.DrawString(" PRC: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(378, 430));
                }
                else if (_PRC == "No")
                {
                    e.Graphics.DrawString(" PRC: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(378, 430));
                }
                else
                {
                    e.Graphics.DrawString(" PRC: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(378, 430));
                }
                if (_PPI == "Yes")
                {
                    e.Graphics.DrawString(" PPI: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(468, 430));
                }
                else if (_PPI == "No")
                {
                    e.Graphics.DrawString(" PPI: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(468, 430));
                }
                else
                {
                    e.Graphics.DrawString(" PPI: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(468, 430));
                }
                if (_IQ == "Yes")
                {
                    e.Graphics.DrawString(" IQ: [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(549, 430));
                }
                else if (_IQ == "No")
                {
                    e.Graphics.DrawString(" IQ: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(549, 430));
                }
                else
                {
                    e.Graphics.DrawString(" IQ: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(549, 430));
                }
                if (_Mission == "Yes")
                {
                    e.Graphics.DrawString(" Frais de mission: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                }
                else if (_Mission == "No")
                {
                    e.Graphics.DrawString(" Frais de mission: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                }
                else
                {
                    e.Graphics.DrawString(" Frais de mission: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                }
                if (_IFRI == "Yes")
                {
                    e.Graphics.DrawString(" IFRI: [ + ]       Autre: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(235, 450));
                }
                else if (_IFRI == "No")
                {
                    e.Graphics.DrawString(" IFRI: [  ]       Autre: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(235, 450));
                }
                else
                {
                    e.Graphics.DrawString(" IFRI: [  ]       Autre: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(235, 450));
                }
                
                e.Graphics.DrawString(" 17.Appréciation Fin Période D'essai: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 480));
                if (_TriChoice == "Concluant")
                {
                    e.Graphics.DrawString(" Période d'essai conclut: [ + ]       Période d'essai à prolonger: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 510));
                    e.Graphics.DrawString(" Essai non concluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                else if (_TriChoice == "prolonger")
                {
                    e.Graphics.DrawString(" Période d'essai conclut: [  ]       Période d'essai à prolonger: [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 510));
                    e.Graphics.DrawString(" Essai non concluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                else if (_TriChoice == "Non Concluant")
                {
                    e.Graphics.DrawString(" Période d'essai conclut: [  ]       Période d'essai à prolonger: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 510));
                    e.Graphics.DrawString(" Essai non concluant: [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                else
                {
                    e.Graphics.DrawString(" Période d'essai conclut: [  ]       Période d'essai à prolonger: [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 510));
                    e.Graphics.DrawString(" Essai non concluant: [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                }
                e.Graphics.DrawString(" Lettre de notification le: " + _NotifDate + "       Réf " + _Ref, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                
                e.Graphics.DrawString(" 18.Formation au sein de CSC EXP: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 580));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 610));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 625));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 640));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 655));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 656));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 671));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 686));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 687));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 702));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 717));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 718));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 733));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 748));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 749));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 764));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 779));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 780));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 795));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 810));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 811));
                e.Graphics.DrawString(" " + _Exer1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 681));
                e.Graphics.DrawString(" " + _Theme1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, 681));
                e.Graphics.DrawString(" " + _FPlace1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(338, 681));
                e.Graphics.DrawString(" " + _FPeriod1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(435, 681));
                e.Graphics.DrawString(" " + _FDate1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(520, 681));
                e.Graphics.DrawString(" " + _Object1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(612, 681));
                e.Graphics.DrawString(" " + _Exer2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 712));
                e.Graphics.DrawString(" " + _Theme2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, 712));
                e.Graphics.DrawString(" " + _FPlace2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(338, 712));
                e.Graphics.DrawString(" " + _FPeriod2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(435, 712));
                e.Graphics.DrawString(" " + _FDate2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(520, 712));
                e.Graphics.DrawString(" " + _Object2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(612, 712));
                e.Graphics.DrawString(" " + _Exer3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 743));
                e.Graphics.DrawString(" " + _Theme3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, 743));
                e.Graphics.DrawString(" " + _FPlace3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(338, 743));
                e.Graphics.DrawString(" " + _FPeriod3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(435, 743));
                e.Graphics.DrawString(" " + _FDate3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(520, 743));
                e.Graphics.DrawString(" " + _Object3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(612, 743));
                e.Graphics.DrawString(" " + _Exer4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 774));
                e.Graphics.DrawString(" " + _Theme4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, 774));
                e.Graphics.DrawString(" " + _FPlace4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(338, 774));
                e.Graphics.DrawString(" " + _FPeriod4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(435, 774));
                e.Graphics.DrawString(" " + _FDate4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(520, 774));
                e.Graphics.DrawString(" " + _Object4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(612, 774));
                e.Graphics.DrawString(" " + _Exer5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 805));
                e.Graphics.DrawString(" " + _Theme5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, 805));
                e.Graphics.DrawString(" " + _FPlace5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(338, 805));
                e.Graphics.DrawString(" " + _FPeriod5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(435, 805));
                e.Graphics.DrawString(" " + _FDate5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(520, 805));
                e.Graphics.DrawString(" " + _Object5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(612, 805));


                e.Graphics.DrawString(" Exercise ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(118, 635));
                e.Graphics.DrawString(" Theme ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(253, 635));
                e.Graphics.DrawString("   Lieu de\n formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(350, 635));
                e.Graphics.DrawString(" Durée ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(450, 635));
                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(540, 635));
                e.Graphics.DrawString(" Objectif de la\n    formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(625, 635));
                
                e.Graphics.DrawString(" 19.Mesures Disciplinaires: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 841));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 871));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 886));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 901));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 916));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 917));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 932));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 947));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 948));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 963));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 978));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 979));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 994));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1009));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1010));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1025));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1040));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1041));
                e.Graphics.DrawString(" "  + _Qualif1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 942));
                e.Graphics.DrawString(" " + _Sanction1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(253, 942));
                e.Graphics.DrawString(" " + _SanDate1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 942));
                e.Graphics.DrawString(" " + _Motif1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(477, 942));
                e.Graphics.DrawString(" " + _Observ1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(623, 942));
                e.Graphics.DrawString(" " + _Qualif2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 973));
                e.Graphics.DrawString(" " + _Sanction2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(253, 973));
                e.Graphics.DrawString(" " + _SanDate2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 973));
                e.Graphics.DrawString(" " + _Motif2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(477, 973));
                e.Graphics.DrawString(" " + _Observ2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(623, 973));
                e.Graphics.DrawString(" " + _Qualif3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 1004));
                e.Graphics.DrawString(" " + _Sanction3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(253, 1004));
                e.Graphics.DrawString(" " + _SanDate3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 1004));
                e.Graphics.DrawString(" " + _Motif3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(477, 1004));
                e.Graphics.DrawString(" " + _Observ3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(623, 1004));
                e.Graphics.DrawString(" " + _Qualif4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 1035));
                e.Graphics.DrawString(" " + _Sanction4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(253, 1035));
                e.Graphics.DrawString(" " + _SanDate4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(380, 1035));
                e.Graphics.DrawString(" " + _Motif4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(477, 1035));
                e.Graphics.DrawString(" " + _Observ4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(623, 1035));

                e.Graphics.DrawString(" Qualifiaction\n   de la faute ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(110, 896));
                e.Graphics.DrawString(" Nature de\n la sanction ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 896));
                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(410, 896));
                e.Graphics.DrawString(" Motif ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(522, 896));
                e.Graphics.DrawString(" Observation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(640, 896));

                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 5)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                
                e.Graphics.DrawString(" 20.Surveillance: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                if (_StpChoice == "Initiale")
                {
                    e.Graphics.DrawString(" Etape:  Initiale [ + ]       suivi1 [  ]       suivi2 [  ]       suivi3 [  ]       non surveillé [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                else if (_StpChoice == "suivi 1")
                {
                    e.Graphics.DrawString(" Etape:  Initiale [  ]       suivi1 [ + ]       suivi2 [  ]       suivi3 [  ]       non surveillé [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                else if (_StpChoice == "suivi 2")
                {
                    e.Graphics.DrawString(" Etape:  Initiale [  ]       suivi1 [  ]       suivi2 [ + ]       suivi3 [  ]       non surveillé [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                else if (_StpChoice == "suivi 3")
                {
                    e.Graphics.DrawString(" Etape:  Initiale [  ]       suivi1 [  ]       suivi2 [  ]       suivi3 [ + ]       non surveillé [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                else if (_StpChoice == "non surveillé")
                {
                    e.Graphics.DrawString(" Etape:  Initiale [  ]       suivi1 [  ]       suivi2 [  ]       suivi3 [  ]       non surveillé [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                else
                {
                    e.Graphics.DrawString(" Etape:  Initiale [  ]       suivi1 [  ]       suivi2 [  ]       suivi3 [  ]       non surveillé [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                }
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 140));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 155));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 170));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 185));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 186));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 201));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 216));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 217));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 232));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 247));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 248));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 263));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 278));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 279));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 294));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 309));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 325));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 340));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 341));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 356));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 371));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 372));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 387));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 402));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 403));
                e.Graphics.DrawString(" " + _SurDate1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 211));
                e.Graphics.DrawString(" " + _Step1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 211));
                e.Graphics.DrawString(" " + _Technic1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 211));
                e.Graphics.DrawString(" " + _Note1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 211));
                e.Graphics.DrawString(" " + _Remark1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 211));
                e.Graphics.DrawString(" " + _SurDate2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 242));
                e.Graphics.DrawString(" " + _Step2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 242));
                e.Graphics.DrawString(" " + _Technic2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 242));
                e.Graphics.DrawString(" " + _Note2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 242));
                e.Graphics.DrawString(" " + _Remark2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 242));
                e.Graphics.DrawString(" " + _SurDate3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 273));
                e.Graphics.DrawString(" " + _Step3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 273));
                e.Graphics.DrawString(" " + _Technic3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 273));
                e.Graphics.DrawString(" " + _Note3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 273));
                e.Graphics.DrawString(" " + _Remark3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 273));
                e.Graphics.DrawString(" " + _SurDate4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 304));
                e.Graphics.DrawString(" " + _Step4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 304));
                e.Graphics.DrawString(" " + _Technic4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 304));
                e.Graphics.DrawString(" " + _Note4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 304));
                e.Graphics.DrawString(" " + _Remark4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 304));
                e.Graphics.DrawString(" " + _SurDate5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 335));
                e.Graphics.DrawString(" " + _Step5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 335));
                e.Graphics.DrawString(" " + _Technic5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 335));
                e.Graphics.DrawString(" " + _Note5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 335));
                e.Graphics.DrawString(" " + _Remark5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 335));
                e.Graphics.DrawString(" " + _SurDate6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 366));
                e.Graphics.DrawString(" " + _Step6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 366));
                e.Graphics.DrawString(" " + _Technic6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 366));
                e.Graphics.DrawString(" " + _Note6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 366));
                e.Graphics.DrawString(" " + _Remark6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 366));
                e.Graphics.DrawString(" " + _SurDate7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 397));
                e.Graphics.DrawString(" " + _Step7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 397));
                e.Graphics.DrawString(" " + _Technic7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 397));
                e.Graphics.DrawString(" " + _Note7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(437, 397));
                e.Graphics.DrawString(" " + _Remark7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(579, 397));


                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(100, 165));
                e.Graphics.DrawString(" Etape ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(195, 165));
                e.Graphics.DrawString(" Technique CND\n        Utilisé ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(290, 165));
                e.Graphics.DrawString(" Notation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(472, 165));
                e.Graphics.DrawString(" Remarque ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(625, 165));
                
                e.Graphics.DrawString(" 21.Evaluation annuelle des compétences: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 433));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 463));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 478));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 493));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 494));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 509));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 524));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 525));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 540));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 555));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 556));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 571));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 586));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 587));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 602));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 617));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 618));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 633));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 648));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 649));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 664));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 679));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 680));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 695));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 710));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 711));
                e.Graphics.DrawString(" " + _EvExer1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 519));
                e.Graphics.DrawString(" " + _NoteG1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 519));
                e.Graphics.DrawString(" " + _Appr1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 519));
                e.Graphics.DrawString(" " + _EvExer2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 550));
                e.Graphics.DrawString(" " + _NoteG2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 550));
                e.Graphics.DrawString(" " + _Appr2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 550));
                e.Graphics.DrawString(" " + _EvExer3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 581));
                e.Graphics.DrawString(" " + _NoteG3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 581));
                e.Graphics.DrawString(" " + _Appr3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 581));
                e.Graphics.DrawString(" " + _EvExer4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 612));
                e.Graphics.DrawString(" " + _NoteG4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 612));
                e.Graphics.DrawString(" " + _Appr4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 612));
                e.Graphics.DrawString(" " + _EvExer5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 643));
                e.Graphics.DrawString(" " + _NoteG5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 643));
                e.Graphics.DrawString(" " + _Appr5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 643));
                e.Graphics.DrawString(" " + _EvExer6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 674));
                e.Graphics.DrawString(" " + _NoteG6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 674));
                e.Graphics.DrawString(" " + _Appr6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 674));
                e.Graphics.DrawString(" " + _EvExer7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(75, 705));
                e.Graphics.DrawString(" " + _NoteG7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 705));
                e.Graphics.DrawString(" " + _Appr7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(517, 705));

                e.Graphics.DrawString(" Exercice ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(135, 488));
                e.Graphics.DrawString(" Notation Global ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(325, 488));
                e.Graphics.DrawString(" Appréciation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(575, 488));
                
                e.Graphics.DrawString(" 22.Pistes d'amélioration: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 741));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 771));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 786));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 801));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 816));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 817));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 832));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 847));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 848));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 863));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 878));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 879));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 894));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 909));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 910));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 925));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 940));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 941));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 956));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 971));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 972));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 987));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1002));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1003));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1018));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1033));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1034));
                e.Graphics.DrawString(" " + _AmExer1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 842));
                e.Graphics.DrawString(" " + _Promo1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 842));
                e.Graphics.DrawString(" " + _Reaffec1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 842));
                e.Graphics.DrawString(" " + _AmForm1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 842));
                e.Graphics.DrawString(" " + _AmAutres1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 842));
                e.Graphics.DrawString(" " + _AmExer2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 873));
                e.Graphics.DrawString(" " + _Promo2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 873));
                e.Graphics.DrawString(" " + _Reaffec2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 873));
                e.Graphics.DrawString(" " + _AmForm2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 873));
                e.Graphics.DrawString(" " + _AmAutres2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 873));
                e.Graphics.DrawString(" " + _AmExer3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 904));
                e.Graphics.DrawString(" " + _Promo3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 904));
                e.Graphics.DrawString(" " + _Reaffec3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 904));
                e.Graphics.DrawString(" " + _AmForm3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 904));
                e.Graphics.DrawString(" " + _AmAutres3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 904));
                e.Graphics.DrawString(" " + _AmExer4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 935));
                e.Graphics.DrawString(" " + _Promo4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 935));
                e.Graphics.DrawString(" " + _Reaffec4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 935));
                e.Graphics.DrawString(" " + _AmForm4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 935));
                e.Graphics.DrawString(" " + _AmAutres4, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 935));
                e.Graphics.DrawString(" " + _AmExer5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 966));
                e.Graphics.DrawString(" " + _Promo5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 966));
                e.Graphics.DrawString(" " + _Reaffec5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 966));
                e.Graphics.DrawString(" " + _AmForm5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 966));
                e.Graphics.DrawString(" " + _AmAutres5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 966));
                e.Graphics.DrawString(" " + _AmExer6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 997));
                e.Graphics.DrawString(" " + _Promo6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 997));
                e.Graphics.DrawString(" " + _Reaffec6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 997));
                e.Graphics.DrawString(" " + _AmForm6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 997));
                e.Graphics.DrawString(" " + _AmAutres6, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 997));
                e.Graphics.DrawString(" " + _AmExer7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(77, 1028));
                e.Graphics.DrawString(" " + _Promo7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(172, 1028));
                e.Graphics.DrawString(" " + _Reaffec7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(321, 1028));
                e.Graphics.DrawString(" " + _AmForm7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(482, 1028));
                e.Graphics.DrawString(" " + _AmAutres7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(625, 1028));


                e.Graphics.DrawString(" Exercice ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 796));
                e.Graphics.DrawString("   Promotion par\névolution de poste ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(178, 796));
                e.Graphics.DrawString(" Réaffectation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(347, 796));
                e.Graphics.DrawString(" Formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(515, 796));
                e.Graphics.DrawString(" Autres ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(660, 796));

                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 6)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                
                e.Graphics.DrawString(" 23.Appréciation Fin Contrat CDD: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                if (_Contract == "concluant")
                {
                    e.Graphics.DrawString(" Contrat concluant:       [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 150));
                    e.Graphics.DrawString(" Contrat non concluant:       [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 190));
                }
                else if (_Contract == "non concluant")
                {
                    e.Graphics.DrawString(" Contrat concluant:       [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 150));
                    e.Graphics.DrawString(" Contrat non concluant:       [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 190));
                }
                else
                {
                    e.Graphics.DrawString(" Contrat concluant:       [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 150));
                    e.Graphics.DrawString(" Contrat non concluant:       [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 190));
                }
                e.Graphics.DrawString(" Contrat de travail renouvelé le: " + _ContDate, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 170));
                e.Graphics.DrawString(" Lettre de notification le: " + _ConNotif + "       N°Ref: " + _ConRef, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 210));

                e.Graphics.DrawString(" 24.Départ: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 240));
                e.Graphics.DrawString(" Date de départ: " + _deparDate, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 270));
                e.Graphics.DrawString(" Catégorie: "+ _deparCateg, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 290));
                e.Graphics.DrawString(" Cause: " + _deparCause, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 310));


                e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1070));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = false;
            }
            page++;
            if (page > 6)
                page = 1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            
            crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Impression de fiche de renseignement','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDocument1.Print();
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
            //textBox1.Text = _Panier;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        crudClass crud = new crudClass();

        public void clear()
        {
            Settings.Default.Reset();
            UserControls.UC_CivilState c_CivilState = new UserControls.UC_CivilState();
            someMat = new fNameFunction(someOtherName);
            c_CivilState.Mat = someMat;
            AddControlsToPanel(c_CivilState);

            movePlacePanel(btnInfo);
            if (pnlButtons.Visible == false)
            {
                pnlButtons.Visible = true;
                pnlButtons1.Visible = false;
            }
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            if (crud.check_Id("T_EmployeInfo", "id_Emp", _Mat) == "Code exists")
            {
                MessageBox.Show("Matricule existe déja");
                clear();
            }
            else
            {
                crud.crudop("insert into T_EmployeInfo (id_Emp, nom, prenom, nom_JeuneFille, date_Naissance, lieu_Naissance, sit_Familiale, nationalité, adresse, téléphone, prenom_Pere, nom_Mere, gr_Sanguin, prof_Pere, prof_Mere, nombre_Frères, nom_Conjoint, date_Mariage, prof_Conjoint, nombre_Enfants, num_Compte, num_Sécurité, num_Carte, délivré, déliv_Le, dagagé, date_Immobilisation, sursitaire_Du, sursitaire_Au, apte_NonIncorp,origine_Choi, origine_Deman, date_Doc, nom_Utilisateur) values ('" + _Mat + "','" + _LName + "','" + _Name + "','" + _NameBefo + "','" + _BirthD + "','" + _BirthP + "','" + _FamSit + "','" + _Nation + "','" + _Adress + "','" + _Phone + "','" + _FathName + "','" + _MothFullName + "','" + _BloodType + "','" + _FathJob + "','" + _MotJob + "','" + _SiblingNum + "','" + _MariName + "','" + _MariDate + "','" + _MariJob + "','" + __ChildNum + "','" + _AccountNum + "','" + _SecuNum + "','" + _CarteNum + "','" + _DeliverBy + "','" + _DeliverDate + "','" + _Engage + "','" + _ImmoDate + "','" + _SursiFrom + "','" + _SursiTo + "','" + _Apte + "','" + _Choice + "','" + _Others + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + userName + "')");
                crud.crudop("insert into T_NiveauSco values ('" + _Mat + "','" + _Etab1 + "','" + _Speci1 + "','" + _Period1 + "','" + _Dipl1 + "','" + _ObtDate1 + "'),('" + _Mat + "','" + _Etab2 + "','" + _Speci2 + "','" + _Period2 + "','" + _Dipl2 + "','" + _ObtDate2 + "'),('" + _Mat + "','" + _Etab3 + "','" + _Speci3 + "','" + _Period3 + "','" + _Dipl3 + "','" + _ObtDate3 + "'),('" + _Mat + "','" + _Etab4 + "','" + _Speci4 + "','" + _Period4 + "','" + _Dipl4 + "','" + _ObtDate4 + "')");
                crud.crudop("insert into T_EnseiProf values ('" + _Mat + "','" + _Etabl1 + "','" + _Spec1 + "','" + _Perio1 + "','" + _Dip1 + "','" + _ObtenDate1 + "'),('"+ _Mat + "','" + _Etabl2 + "','" + _Spec2 + "','" + _Perio2 + "','" + _Dip2 + "','" + _ObtenDate2 + "'),('" + _Mat + "','" + _Etabl3 + "','" + _Spec3 + "','" + _Perio3 + "','" + _Dip3 + "','" + _ObtenDate3 + "'),('" + _Mat + "','" + _Etabl4 + "','" + _Spec4 + "','" + _Perio4 + "','" + _Dip4 + "','" + _ObtenDate4 + "')");
                crud.crudop("insert into T_Stages values ('" + _Mat + "','" + _E1 + "','" + _S1 + "','" + _P1 + "','" + _D1 + "','" + _O1 + "'),('" + _Mat + "','" + _E2 + "','" + _S2 + "','" + _P2 + "','" + _D2 + "','" + _O2 + "'),('" + _Mat + "','" + _E3 + "','" + _S3 + "','" + _P3 + "','" + _D3 + "','" + _O3 + "'),('" + _Mat + "','" + _E4 + "','" + _S4 + "','" + _P4 + "','" + _D4 + "','" + _O4 + "')");
                crud.crudop("insert into T_Carriere values ('" + _Mat + "','" + _Emp1 + "','" + _Work1 + "','" + _From1 + "','" + _To1 + "','" + _Motive1 + "'),('" + _Mat + "','" + _Emp2 + "','" + _Work2 + "','" + _From2 + "','" + _To2 + "','" + _Motive2 + "'),('" + _Mat + "','" + _Emp2 + "','" + _Work3 + "','" + _From3 + "','" + _To3 + "','" + _Motive3 + "'),('" + _Mat + "','" + _Emp4 + "','" + _Work4 + "','" + _From4 + "','" + _To4 + "','" + _Motive4 + "')");
                crud.crudop("insert into T_Langue values ('" + _Mat + "','" + _FreL + "','" + _AraL + "','" + _EngL + "','" + _GerL + "','" + _OthL + "','" + _Other + "')");
                crud.crudop("insert into T_Logiciel values ('" + _Mat + "','" + _Soft1 + "','" + _Form1 + "','" + _Leve1 + "'),('" + _Mat + "','" + _Soft2 + "','" + _Form2 + "','" + _Leve2 + "'),('" + _Mat + "','" + _Soft3 + "','" + _Form3 + "','" + _Leve3 + "'),('" + _Mat + "','" + _Soft4 + "','" + _Form4 + "','" + _Leve4 + "')");
                crud.crudop("insert into T_Projets values ('" + _Mat + "','" + _Projects + "')");
                crud.crudop("insert into T_Intéret values ('" + _Mat + "','" + _Inter1 + "'),('" + _Mat + "','" + _Inter2 + "'),('" + _Mat + "','" + _Inter3 + "'),('" + _Mat + "','" + _Inter4 + "'),('" + _Mat + "','" + _Inter5 + "'),('" + _Mat + "','" + _Inter6 + "'),('" + _Mat + "','" + _Inter7 + "'),('" + _Mat + "','" + _Inter8 + "')");
                crud.crudop("insert into T_Connaissance values ('" + _Mat + "','" + _Name1 + "','" + _FName1 + "','" + _Job1 + "'),('" + _Mat + "','" + _Name2 + "','" + _FName2 + "','" + _Job2 + "')");

                crud.crudop("insert into T_Test values ('" + _Mat + "','" + _Med + "','" + _Prof + "')");
                crud.crudop("insert into T_Contrat values ('" + _Mat + "','" + _ContrD + "','" + _Post + "','" + _Service + "','" + _EngageD + "','" + _Etat + "')");
                crud.crudop("insert into T_Primes values ('" + _Mat + "','" + _Salary + "','" + _IEP + "','" + _Panier + "','" + _Trans + "','" + _Saliss + "','" + _Indemn + "','" + _Deplace + "','" + _Danger + "','" + _TPhone + "','" + _Penib + "','" + _Insalub + "','" + _Fidel + "','" + _PRI + "','" + _PRC + "','" + _PPI + "','" + _IQ + "','" + _Mission + "','" + _IFRI + "','" + _Autre + "')");
                crud.crudop("insert into T_FinEssai values ('" + _Mat + "','" + _TriChoice + "','" + _NotifDate + "','" + _Ref + "')");
                crud.crudop("insert into T_Formation values ('" + _Mat + "','" + _Exer1 + "','" + _Theme1 + "','" + _FPlace1 + "','" + _FPeriod1 + "','" + _FDate1 + "','" + _Object1 + "'),('" + _Mat + "','" + _Exer2 + "','" + _Theme2 + "','" + _FPlace2 + "','" + _FPeriod2 + "','" + _FDate2 + "','" + _Object2 + "'),('" + _Mat + "','" + _Exer3 + "','" + _Theme3 + "','" + _FPlace3 + "','" + _FPeriod3 + "','" + _FDate3 + "','" + _Object3 + "'),('" + _Mat + "','" + _Exer4 + "','" + _Theme4 + "','" + _FPlace4 + "','" + _FPeriod4 + "','" + _FDate4 + "','" + _Object4 + "'),('" + _Mat + "','" + _Exer5 + "','" + _Theme5 + "','" + _FPlace5 + "','" + _FPeriod5 + "','" + _FDate5 + "','" + _Object5 + "')");
                crud.crudop("insert into T_Discipline values ('" + _Mat + "','" + _Qualif1 + "','" + _Sanction1 + "','" + _SanDate1 + "','" + _Motif1 + "','" + _Observ1 + "'),('" + _Mat + "','" + _Qualif2 + "','" + _Sanction2 + "','" + _SanDate2 + "','" + _Motif2 + "','" + _Observ2 + "'),('" + _Mat + "','" + _Qualif3 + "','" + _Sanction3 + "','" + _SanDate3 + "','" + _Motif3 + "','" + _Observ3 + "'),('" + _Mat + "','" + _Qualif4 + "','" + _Sanction4 + "','" + _SanDate4 + "','" + _Motif4 + "','" + _Observ4 + "')");
                crud.crudop("insert into T_Surveille values ('" + _Mat + "','" + _StpChoice + "','" + _SurDate1 + "','" + _Step1 + "','" + _Technic1 + "','" + _Note1 + "','" + _Remark1 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate2 + "','" + _Step2 + "','" + _Technic2 + "','" + _Note2 + "','" + _Remark2 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate3 + "','" + _Step3 + "','" + _Technic3 + "','" + _Note3 + "','" + _Remark3 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate4 + "','" + _Step4 + "','" + _Technic4 + "','" + _Note4 + "','" + _Remark4 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate5 + "','" + _Step5 + "','" + _Technic5 + "','" + _Note5 + "','" + _Remark5 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate6 + "','" + _Step6 + "','" + _Technic6 + "','" + _Note6 + "','" + _Remark6 + "'),('" + _Mat + "','" + _StpChoice + "','" + _SurDate7 + "','" + _Step7 + "','" + _Technic7 + "','" + _Note7 + "','" + _Remark7 + "')");
                crud.crudop("insert into T_Evaluation values ('" + _Mat + "','" + _EvExer1 + "','" + _NoteG1 + "','" + _Appr1 + "'),('" + _Mat + "','" + _EvExer2 + "','" + _NoteG2 + "','" + _Appr2 + "'),('" + _Mat + "','" + _EvExer3 + "','" + _NoteG3 + "','" + _Appr3 + "'),('" + _Mat + "','" + _EvExer4 + "','" + _NoteG4 + "','" + _Appr4 + "'),('" + _Mat + "','" + _EvExer5 + "','" + _NoteG5 + "','" + _Appr5 + "'),('" + _Mat + "','" + _EvExer6 + "','" + _NoteG6 + "','" + _Appr6 + "'),('" + _Mat + "','" + _EvExer7 + "','" + _NoteG7 + "','" + _Appr7 + "')");
                crud.crudop("insert into T_Amelioration values ('" + _Mat + "','" + _AmExer1 + "','" + _Promo1 + "','" + _Reaffec1 + "','" + _AmForm1 + "','" + _AmAutres1 + "'),('" + _Mat + "','" + _AmExer2 + "','" + _Promo2 + "','" + _Reaffec2 + "','" + _AmForm2 + "','" + _AmAutres2 + "'),('" + _Mat + "','" + _AmExer3 + "','" + _Promo3 + "','" + _Reaffec3 + "','" + _AmForm3 + "','" + _AmAutres3 + "'),('" + _Mat + "','" + _AmExer4 + "','" + _Promo4 + "','" + _Reaffec4 + "','" + _AmForm4 + "','" + _AmAutres4 + "'),('" + _Mat + "','" + _AmExer5 + "','" + _Promo5 + "','" + _Reaffec5 + "','" + _AmForm5 + "','" + _AmAutres5 + "'),('" + _Mat + "','" + _AmExer6 + "','" + _Promo6 + "','" + _Reaffec6 + "','" + _AmForm6 + "','" + _AmAutres6 + "'),('" + _Mat + "','" + _AmExer7 + "','" + _Promo7 + "','" + _Reaffec7 + "','" + _AmForm7 + "','" + _AmAutres7 + "')");
                crud.crudop("insert into T_FinContrat values ('" + _Mat + "','" + _Contract + "','" + _ContDate + "','" + _ConNotif + "','" + _ConRef + "')");
                if (_deparCateg != "")
                {
                    crud.crudop("update T_Contrat set Etat=Null where id_Emp='" + _Mat + "'");
                }
                crud.crudop("insert into T_Depart values ('" + _Mat + "','" + _deparDate + "','" + _deparCateg + "','" + _deparCause + "','" + _autreCause + "')");

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de nouveau employé','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");


                MessageBox.Show("Vos données ont été enregistrées");
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_EmployeInfo set nom='" + _LName + "', prenom='" + _Name + "',nom_JeuneFille='" + _NameBefo + "',date_Naissance='" + _BirthD + "',lieu_Naissance='" + _BirthP + "',sit_Familiale='" + _FamSit + "',nationalité='" + _Nation + "',adresse='" + _Adress + "',téléphone='" + _Phone + "',prenom_Pere='" + _FathName + "',nom_Mere='" + _MothFullName + "',gr_Sanguin='" + _BloodType + "',prof_Pere='" + _FathJob + "',prof_Mere='" + _MotJob + "',nombre_Frères='" + _SiblingNum + "',nom_Conjoint='" + _MariName + "',date_Mariage='" + _MariDate + "',prof_Conjoint='" + _MariJob + "',nombre_Enfants='" + __ChildNum + "',num_Compte='" + _AccountNum + "',num_Sécurité='" + _SecuNum + "',num_Carte='" + _CarteNum + "',délivré='" + _DeliverBy + "',déliv_Le='" + _DeliverDate + "',dagagé='" + _Engage + "',date_Immobilisation='" + _ImmoDate + "',sursitaire_Du='" + _SursiFrom + "',sursitaire_Au='" + _SursiTo + "',apte_NonIncorp='" + _Apte + "',origine_Deman='" + _Others + "',origine_Choi='" + _Choice + "' where id_Emp='" + _Mat + "'");
                
                crud.updateMultiRows("T_NiveauSco", "etablissement", _Etab1, "id_Niv", Settings.Default.id_NivSco);
                crud.updateMultiRows("T_NiveauSco", "spécialité", _Speci1, "id_Niv", Settings.Default.id_NivSco);
                crud.updateMultiRows("T_NiveauSco", "période", _Period1, "id_Niv", Settings.Default.id_NivSco);
                crud.updateMultiRows("T_NiveauSco", "diplome", _Dipl1, "id_Niv", Settings.Default.id_NivSco);
                crud.updateMultiRows("T_NiveauSco", "année_Obtention", _ObtDate1, "id_Niv", Settings.Default.id_NivSco);
                crud.updateMultiRows("T_NiveauSco", "etablissement", _Etab2, "id_Niv", Settings.Default.id_NivSco1);
                crud.updateMultiRows("T_NiveauSco", "spécialité", _Speci2, "id_Niv", Settings.Default.id_NivSco1);
                crud.updateMultiRows("T_NiveauSco", "période", _Period2, "id_Niv", Settings.Default.id_NivSco1);
                crud.updateMultiRows("T_NiveauSco", "diplome", _Dipl2, "id_Niv", Settings.Default.id_NivSco1);
                crud.updateMultiRows("T_NiveauSco", "année_Obtention", _ObtDate2, "id_Niv", Settings.Default.id_NivSco1);
                crud.updateMultiRows("T_NiveauSco", "etablissement", _Etab3, "id_Niv", Settings.Default.id_NivSco2);
                crud.updateMultiRows("T_NiveauSco", "spécialité", _Speci3, "id_Niv", Settings.Default.id_NivSco2);
                crud.updateMultiRows("T_NiveauSco", "période", _Period3, "id_Niv", Settings.Default.id_NivSco2);
                crud.updateMultiRows("T_NiveauSco", "diplome", _Dipl3, "id_Niv", Settings.Default.id_NivSco2);
                crud.updateMultiRows("T_NiveauSco", "année_Obtention", _ObtDate3, "id_Niv", Settings.Default.id_NivSco2);
                crud.updateMultiRows("T_NiveauSco", "etablissement", _Etab4, "id_Niv", Settings.Default.id_NivSco3);
                crud.updateMultiRows("T_NiveauSco", "spécialité", _Speci4, "id_Niv", Settings.Default.id_NivSco3);
                crud.updateMultiRows("T_NiveauSco", "période", _Period4, "id_Niv", Settings.Default.id_NivSco3);
                crud.updateMultiRows("T_NiveauSco", "diplome", _Dipl4, "id_Niv", Settings.Default.id_NivSco3);
                crud.updateMultiRows("T_NiveauSco", "année_Obtention", _ObtDate4, "id_Niv", Settings.Default.id_NivSco3);

                crud.updateMultiRows("T_EnseiProf", "etablissement", _Etabl1, "id_Ensei", Settings.Default.id_EnsProf);
                crud.updateMultiRows("T_EnseiProf", "spécialité", _Spec1, "id_Ensei", Settings.Default.id_EnsProf);
                crud.updateMultiRows("T_EnseiProf", "période", _Perio1, "id_Ensei", Settings.Default.id_EnsProf);
                crud.updateMultiRows("T_EnseiProf", "diplome", _Dip1, "id_Ensei", Settings.Default.id_EnsProf);
                crud.updateMultiRows("T_EnseiProf", "année_Obtention", _ObtenDate1, "id_Ensei", Settings.Default.id_EnsProf);
                crud.updateMultiRows("T_EnseiProf", "etablissement", _Etabl2, "id_Ensei", Settings.Default.id_EnsProf1);
                crud.updateMultiRows("T_EnseiProf", "spécialité", _Spec2, "id_Ensei", Settings.Default.id_EnsProf1);
                crud.updateMultiRows("T_EnseiProf", "période", _Perio2, "id_Ensei", Settings.Default.id_EnsProf1);
                crud.updateMultiRows("T_EnseiProf", "diplome", _Dip2, "id_Ensei", Settings.Default.id_EnsProf1);
                crud.updateMultiRows("T_EnseiProf", "année_Obtention", _ObtenDate2, "id_Ensei", Settings.Default.id_EnsProf1);
                crud.updateMultiRows("T_EnseiProf", "etablissement", _Etabl3, "id_Ensei", Settings.Default.id_EnsProf2);
                crud.updateMultiRows("T_EnseiProf", "spécialité", _Spec3, "id_Ensei", Settings.Default.id_EnsProf2);
                crud.updateMultiRows("T_EnseiProf", "période", _Perio3, "id_Ensei", Settings.Default.id_EnsProf2);
                crud.updateMultiRows("T_EnseiProf", "diplome", _Dip3, "id_Ensei", Settings.Default.id_EnsProf2);
                crud.updateMultiRows("T_EnseiProf", "année_Obtention", _ObtenDate3, "id_Ensei", Settings.Default.id_EnsProf2);
                crud.updateMultiRows("T_EnseiProf", "etablissement", _Etabl4, "id_Ensei", Settings.Default.id_EnsProf3);
                crud.updateMultiRows("T_EnseiProf", "spécialité", _Spec4, "id_Ensei", Settings.Default.id_EnsProf3);
                crud.updateMultiRows("T_EnseiProf", "période", _Perio4, "id_Ensei", Settings.Default.id_EnsProf3);
                crud.updateMultiRows("T_EnseiProf", "diplome", _Dip4, "id_Ensei", Settings.Default.id_EnsProf3);
                crud.updateMultiRows("T_EnseiProf", "année_Obtention", _ObtenDate4, "id_Ensei", Settings.Default.id_EnsProf3);

                crud.updateMultiRows("T_Stages", "etablissement", _E1, "id_Stag", Settings.Default.id_Stag);
                crud.updateMultiRows("T_Stages", "spécialité", _S1, "id_Stag", Settings.Default.id_Stag);
                crud.updateMultiRows("T_Stages", "période", _P1, "id_Stag", Settings.Default.id_Stag);
                crud.updateMultiRows("T_Stages", "diplome", _D1, "id_Stag", Settings.Default.id_Stag);
                crud.updateMultiRows("T_Stages", "année_Obtention", _O1, "id_Stag", Settings.Default.id_Stag);
                crud.updateMultiRows("T_Stages", "etablissement", _E2, "id_Stag", Settings.Default.id_Stag1);
                crud.updateMultiRows("T_Stages", "spécialité", _S2, "id_Stag", Settings.Default.id_Stag1);
                crud.updateMultiRows("T_Stages", "période", _P2, "id_Stag", Settings.Default.id_Stag1);
                crud.updateMultiRows("T_Stages", "diplome", _D2, "id_Stag", Settings.Default.id_Stag1);
                crud.updateMultiRows("T_Stages", "année_Obtention", _O2, "id_Stag", Settings.Default.id_Stag1);
                crud.updateMultiRows("T_Stages", "etablissement", _E3, "id_Stag", Settings.Default.id_Stag2);
                crud.updateMultiRows("T_Stages", "spécialité", _S3, "id_Stag", Settings.Default.id_Stag2);
                crud.updateMultiRows("T_Stages", "période", _P3, "id_Stag", Settings.Default.id_Stag2);
                crud.updateMultiRows("T_Stages", "diplome", _D3, "id_Stag", Settings.Default.id_Stag2);
                crud.updateMultiRows("T_Stages", "année_Obtention", _O3, "id_Stag", Settings.Default.id_Stag2);
                crud.updateMultiRows("T_Stages", "etablissement", _E4, "id_Stag", Settings.Default.id_Stag3);
                crud.updateMultiRows("T_Stages", "spécialité", _S4, "id_Stag", Settings.Default.id_Stag3);
                crud.updateMultiRows("T_Stages", "période", _P4, "id_Stag", Settings.Default.id_Stag3);
                crud.updateMultiRows("T_Stages", "diplome", _D4, "id_Stag", Settings.Default.id_Stag3);
                crud.updateMultiRows("T_Stages", "année_Obtention", _O4, "id_Stag", Settings.Default.id_Stag3);

                crud.updateMultiRows("T_Carriere", "employeur", _Emp1, "id_Carr", Settings.Default.id_Carr);
                crud.updateMultiRows("T_Carriere", "emploi", _Work1, "id_Carr", Settings.Default.id_Carr);
                crud.updateMultiRows("T_Carriere", "date_Debut", _From1, "id_Carr", Settings.Default.id_Carr);
                crud.updateMultiRows("T_Carriere", "date_Fin", _To1, "id_Carr", Settings.Default.id_Carr);
                crud.updateMultiRows("T_Carriere", "motif_Depart", _Motive1, "id_Carr", Settings.Default.id_Carr);
                crud.updateMultiRows("T_Carriere", "employeur", _Emp2, "id_Carr", Settings.Default.id_Carr1);
                crud.updateMultiRows("T_Carriere", "emploi", _Work2, "id_Carr", Settings.Default.id_Carr1);
                crud.updateMultiRows("T_Carriere", "date_Debut", _From2, "id_Carr", Settings.Default.id_Carr1);
                crud.updateMultiRows("T_Carriere", "date_Fin", _To2, "id_Carr", Settings.Default.id_Carr1);
                crud.updateMultiRows("T_Carriere", "motif_Depart", _Motive2, "id_Carr", Settings.Default.id_Carr1);
                crud.updateMultiRows("T_Carriere", "employeur", _Emp3, "id_Carr", Settings.Default.id_Carr2);
                crud.updateMultiRows("T_Carriere", "emploi", _Work3, "id_Carr", Settings.Default.id_Carr2);
                crud.updateMultiRows("T_Carriere", "date_Debut", _From3, "id_Carr", Settings.Default.id_Carr2);
                crud.updateMultiRows("T_Carriere", "date_Fin", _To3, "id_Carr", Settings.Default.id_Carr2);
                crud.updateMultiRows("T_Carriere", "motif_Depart", _Motive3, "id_Carr", Settings.Default.id_Carr2);
                crud.updateMultiRows("T_Carriere", "employeur", _Emp4, "id_Carr", Settings.Default.id_Carr3);
                crud.updateMultiRows("T_Carriere", "emploi", _Work4, "id_Carr", Settings.Default.id_Carr3);
                crud.updateMultiRows("T_Carriere", "date_Debut", _From4, "id_Carr", Settings.Default.id_Carr3);
                crud.updateMultiRows("T_Carriere", "date_Fin", _To4, "id_Carr", Settings.Default.id_Carr3);
                crud.updateMultiRows("T_Carriere", "motif_Depart", _Motive4, "id_Carr", Settings.Default.id_Carr3);

                crud.crudop("update T_Langue set francais='" + _FreL + "', arabe='" + _AraL + "',anglais='" + _EngL + "',allemand='" + _GerL + "',autre='" + _OthL + "',niv_Autre='" + _Other + "' where id_Emp='" + _Mat + "'");

                crud.updateMultiRows("T_Logiciel", "nom_Logiciel", _Soft1, "id_Log", Settings.Default.id_Log);
                crud.updateMultiRows("T_Logiciel", "formation", _Form1, "id_Log", Settings.Default.id_Log);
                crud.updateMultiRows("T_Logiciel", "niveau", _Leve1, "id_Log", Settings.Default.id_Log);
                crud.updateMultiRows("T_Logiciel", "nom_Logiciel", _Soft2, "id_Log", Settings.Default.id_Log1);
                crud.updateMultiRows("T_Logiciel", "formation", _Form2, "id_Log", Settings.Default.id_Log1);
                crud.updateMultiRows("T_Logiciel", "niveau", _Leve2, "id_Log", Settings.Default.id_Log1);
                crud.updateMultiRows("T_Logiciel", "nom_Logiciel", _Soft3, "id_Log", Settings.Default.id_Log2);
                crud.updateMultiRows("T_Logiciel", "formation", _Form3, "id_Log", Settings.Default.id_Log2);
                crud.updateMultiRows("T_Logiciel", "niveau", _Leve3, "id_Log", Settings.Default.id_Log2);
                crud.updateMultiRows("T_Logiciel", "nom_Logiciel", _Soft4, "id_Log", Settings.Default.id_Log3);
                crud.updateMultiRows("T_Logiciel", "formation", _Form4, "id_Log", Settings.Default.id_Log3);
                crud.updateMultiRows("T_Logiciel", "niveau", _Leve4, "id_Log", Settings.Default.id_Log3);

                crud.crudop("update T_Projets set projets='" + _Projects + "' where id_Emp='" + _Mat + "'");

                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter1, "id_Inter", Settings.Default.id_Inter);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter2, "id_Inter", Settings.Default.id_inter1);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter3, "id_Inter", Settings.Default.id_Inter2);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter4, "id_Inter", Settings.Default.id_Inter3);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter5, "id_Inter", Settings.Default.id_Inter4);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter6, "id_Inter", Settings.Default.id_Inter5);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter7, "id_Inter", Settings.Default.id_Inter6);
                crud.updateMultiRows("T_Intéret", "centre_Intéret", _Inter8, "id_Inter", Settings.Default.id_Inter7);

                crud.updateMultiRows("T_Connaissance", "nom_Con", _FName1, "id_Con", Settings.Default.id_Conn);
                crud.updateMultiRows("T_Connaissance", "prenom_Con", _Name1, "id_Con", Settings.Default.id_Conn);
                crud.updateMultiRows("T_Connaissance", "fonctio_Con", _Job1, "id_Con", Settings.Default.id_Conn);
                crud.updateMultiRows("T_Connaissance", "nom_Con", _FName2, "id_Con", Settings.Default.id_Conn1);
                crud.updateMultiRows("T_Connaissance", "prenom_Con", _Name2, "id_Con", Settings.Default.id_Conn1);
                crud.updateMultiRows("T_Connaissance", "fonctio_Con", _Job2, "id_Con", Settings.Default.id_Conn1);

                crud.crudop("update T_Test set med_Test='" + _Med + "',prof_Test='" + _Prof + "' where id_Emp='" + _Mat + "'");

                crud.crudop("update T_Contrat set date_Cont='" + _ContrD + "',fonction='" + _Post + "',direction='" + _Service + "',date_Engage='" + _EngageD + "',Etat='" + _Etat + "' where id_Emp='" + _Mat + "'");

                crud.crudop("update T_Primes set salaire='" + _Salary + "',iep='" + _IEP + "',panier='" + _Panier + "',transport='" + _Trans + "',salissure='" + _Saliss + "',indemnité='" + _Indemn + "',deplace='" + _Deplace + "',danger='" + _Danger + "',phone='" + _TPhone + "',penibilité='" + _Penib + "',insalubrité='" + _Insalub + "',fidelité='" + _Fidel + "',pri='" + _PRI + "',prc='" + _PRC + "',ppi='" + _PPI + "',iq='" + _IQ + "',mission='" + _Mission + "',ifri='" + _IFRI + "',autre='" + _Autre + "' where id_Emp='" + _Mat + "'");

                crud.crudop("update T_FinEssai set period_Essai='" + _TriChoice + "',date_Notif='" + _NotifDate + "',num_Ref='" + _Ref + "' where id_Emp='" + _Mat + "'");

                crud.updateMultiRows("T_Formation", "exercice", _Exer1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "theme", _Theme1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "lieu_Form", _FPlace1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "durée", _FPeriod1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "date_Form", _FDate1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "objectif", _Object1, "id_Form", Settings.Default.id_Form);
                crud.updateMultiRows("T_Formation", "exercice", _Exer2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "theme", _Theme2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "lieu_Form", _FPlace2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "durée", _FPeriod2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "date_Form", _FDate2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "objectif", _Object2, "id_Form", Settings.Default.id_Form1);
                crud.updateMultiRows("T_Formation", "exercice", _Exer3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "theme", _Theme3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "lieu_Form", _FPlace3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "durée", _FPeriod3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "date_Form", _FDate3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "objectif", _Object3, "id_Form", Settings.Default.id_Form2);
                crud.updateMultiRows("T_Formation", "exercice", _Exer1, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "theme", _Theme4, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "lieu_Form", _FPlace4, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "durée", _FPeriod4, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "date_Form", _FDate4, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "objectif", _Object4, "id_Form", Settings.Default.id_Form3);
                crud.updateMultiRows("T_Formation", "exercice", _Exer5, "id_Form", Settings.Default.id_Form4);
                crud.updateMultiRows("T_Formation", "theme", _Theme5, "id_Form", Settings.Default.id_Form4);
                crud.updateMultiRows("T_Formation", "lieu_Form", _FPlace5, "id_Form", Settings.Default.id_Form4);
                crud.updateMultiRows("T_Formation", "durée", _FPeriod5, "id_Form", Settings.Default.id_Form4);
                crud.updateMultiRows("T_Formation", "date_Form", _FDate5, "id_Form", Settings.Default.id_Form4);
                crud.updateMultiRows("T_Formation", "objectif", _Object5, "id_Form", Settings.Default.id_Form4);

                crud.updateMultiRows("T_Discipline", "qualif", _Qualif1, "id_Discip", Settings.Default.id_Desi);
                crud.updateMultiRows("T_Discipline", "nature_Sanc", _Sanction1, "id_Discip", Settings.Default.id_Desi);
                crud.updateMultiRows("T_Discipline", "date_Sanc", _SanDate1, "id_Discip", Settings.Default.id_Desi);
                crud.updateMultiRows("T_Discipline", "motif", _Motif1, "id_Discip", Settings.Default.id_Desi);
                crud.updateMultiRows("T_Discipline", "observation", _Observ1, "id_Discip", Settings.Default.id_Desi);
                crud.updateMultiRows("T_Discipline", "qualif", _Qualif2, "id_Discip", Settings.Default.id_Desi1);
                crud.updateMultiRows("T_Discipline", "nature_Sanc", _Sanction2, "id_Discip", Settings.Default.id_Desi1);
                crud.updateMultiRows("T_Discipline", "date_Sanc", _SanDate2, "id_Discip", Settings.Default.id_Desi1);
                crud.updateMultiRows("T_Discipline", "motif", _Motif2, "id_Discip", Settings.Default.id_Desi1);
                crud.updateMultiRows("T_Discipline", "observation", _Observ2, "id_Discip", Settings.Default.id_Desi1);
                crud.updateMultiRows("T_Discipline", "qualif", _Qualif3, "id_Discip", Settings.Default.id_Desi2);
                crud.updateMultiRows("T_Discipline", "nature_Sanc", _Sanction3, "id_Discip", Settings.Default.id_Desi2);
                crud.updateMultiRows("T_Discipline", "date_Sanc", _SanDate3, "id_Discip", Settings.Default.id_Desi2);
                crud.updateMultiRows("T_Discipline", "motif", _Motif3, "id_Discip", Settings.Default.id_Desi2);
                crud.updateMultiRows("T_Discipline", "observation", _Observ3, "id_Discip", Settings.Default.id_Desi2);
                crud.updateMultiRows("T_Discipline", "qualif", _Qualif4, "id_Discip", Settings.Default.id_Desi3);
                crud.updateMultiRows("T_Discipline", "nature_Sanc", _Sanction4, "id_Discip", Settings.Default.id_Desi3);
                crud.updateMultiRows("T_Discipline", "date_Sanc", _SanDate4, "id_Discip", Settings.Default.id_Desi3);
                crud.updateMultiRows("T_Discipline", "motif", _Motif4, "id_Discip", Settings.Default.id_Desi3);
                crud.updateMultiRows("T_Discipline", "observation", _Observ4, "id_Discip", Settings.Default.id_Desi3);

                crud.crudop("update T_Surveille set etape_Choisi='" + _StpChoice + "' where id_Emp='" + _Mat + "'");

                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate1, "id_Surv", Settings.Default.id_Surve);
                crud.updateMultiRows("T_Surveille", "etape", _Step1, "id_Surv", Settings.Default.id_Surve);
                crud.updateMultiRows("T_Surveille", "technique", _Technic1, "id_Surv", Settings.Default.id_Surve);
                crud.updateMultiRows("T_Surveille", "notation", _Note1, "id_Surv", Settings.Default.id_Surve);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark1, "id_Surv", Settings.Default.id_Surve);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate2, "id_Surv", Settings.Default.id_Surve1);
                crud.updateMultiRows("T_Surveille", "etape", _Step2, "id_Surv", Settings.Default.id_Surve1);
                crud.updateMultiRows("T_Surveille", "technique", _Technic2, "id_Surv", Settings.Default.id_Surve1);
                crud.updateMultiRows("T_Surveille", "notation", _Note2, "id_Surv", Settings.Default.id_Surve1);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark2, "id_Surv", Settings.Default.id_Surve1);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate3, "id_Surv", Settings.Default.id_Surve2);
                crud.updateMultiRows("T_Surveille", "etape", _Step3, "id_Surv", Settings.Default.id_Surve2);
                crud.updateMultiRows("T_Surveille", "technique", _Technic3, "id_Surv", Settings.Default.id_Surve2);
                crud.updateMultiRows("T_Surveille", "notation", _Note3, "id_Surv", Settings.Default.id_Surve2);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark3, "id_Surv", Settings.Default.id_Surve2);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate4, "id_Surv", Settings.Default.id_Surve3);
                crud.updateMultiRows("T_Surveille", "etape", _Step4, "id_Surv", Settings.Default.id_Surve3);
                crud.updateMultiRows("T_Surveille", "technique", _Technic4, "id_Surv", Settings.Default.id_Surve3);
                crud.updateMultiRows("T_Surveille", "notation", _Note4, "id_Surv", Settings.Default.id_Surve3);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark4, "id_Surv", Settings.Default.id_Surve3);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate5, "id_Surv", Settings.Default.id_Surve4);
                crud.updateMultiRows("T_Surveille", "etape", _Step5, "id_Surv", Settings.Default.id_Surve4);
                crud.updateMultiRows("T_Surveille", "technique", _Technic5, "id_Surv", Settings.Default.id_Surve4);
                crud.updateMultiRows("T_Surveille", "notation", _Note5, "id_Surv", Settings.Default.id_Surve4);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark5, "id_Surv", Settings.Default.id_Surve4);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate6, "id_Surv", Settings.Default.id_Surve5);
                crud.updateMultiRows("T_Surveille", "etape", _Step6, "id_Surv", Settings.Default.id_Surve5);
                crud.updateMultiRows("T_Surveille", "technique", _Technic6, "id_Surv", Settings.Default.id_Surve5);
                crud.updateMultiRows("T_Surveille", "notation", _Note6, "id_Surv", Settings.Default.id_Surve5);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark6, "id_Surv", Settings.Default.id_Surve5);
                crud.updateMultiRows("T_Surveille", "date_Surv", _SurDate7, "id_Surv", Settings.Default.id_Surve6);
                crud.updateMultiRows("T_Surveille", "etape", _Step7, "id_Surv", Settings.Default.id_Surve6);
                crud.updateMultiRows("T_Surveille", "technique", _Technic7, "id_Surv", Settings.Default.id_Surve6);
                crud.updateMultiRows("T_Surveille", "notation", _Note7, "id_Surv", Settings.Default.id_Surve6);
                crud.updateMultiRows("T_Surveille", "remarque", _Remark7, "id_Surv", Settings.Default.id_Surve6);

                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer1, "id_Eval", Settings.Default.id_Eval);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG1, "id_Eval", Settings.Default.id_Eval);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr1, "id_Eval", Settings.Default.id_Eval);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer2, "id_Eval", Settings.Default.id_Eval1);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG2, "id_Eval", Settings.Default.id_Eval1);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr2, "id_Eval", Settings.Default.id_Eval1);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer3, "id_Eval", Settings.Default.id_Eval2);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG3, "id_Eval", Settings.Default.id_Eval2);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr3, "id_Eval", Settings.Default.id_Eval2);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer4, "id_Eval", Settings.Default.id_Eval3);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG4, "id_Eval", Settings.Default.id_Eval3);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr4, "id_Eval", Settings.Default.id_Eval3);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer5, "id_Eval", Settings.Default.id_Eval4);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG5, "id_Eval", Settings.Default.id_Eval4);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr5, "id_Eval", Settings.Default.id_Eval4);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer6, "id_Eval", Settings.Default.id_Eval5);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG6, "id_Eval", Settings.Default.id_Eval5);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr6, "id_Eval", Settings.Default.id_Eval5);
                crud.updateMultiRows("T_Evaluation", "exercice", _EvExer7, "id_Eval", Settings.Default.id_Eval6);
                crud.updateMultiRows("T_Evaluation", "not_Glob", _NoteG7, "id_Eval", Settings.Default.id_Eval6);
                crud.updateMultiRows("T_Evaluation", "appreciation", _Appr7, "id_Eval", Settings.Default.id_Eval6);

                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer1, "id_Amelio", Settings.Default.id_Ame);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo1, "id_Amelio", Settings.Default.id_Ame);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec1, "id_Amelio", Settings.Default.id_Ame);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm1, "id_Amelio", Settings.Default.id_Ame);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres1, "id_Amelio", Settings.Default.id_Ame);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer2, "id_Amelio", Settings.Default.id_Ame1);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo2, "id_Amelio", Settings.Default.id_Ame1);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec2, "id_Amelio", Settings.Default.id_Ame1);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm2, "id_Amelio", Settings.Default.id_Ame1);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres2, "id_Amelio", Settings.Default.id_Ame1);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer3, "id_Amelio", Settings.Default.id_Ame2);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo3, "id_Amelio", Settings.Default.id_Ame2);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec3, "id_Amelio", Settings.Default.id_Ame2);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm3, "id_Amelio", Settings.Default.id_Ame2);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres3, "id_Amelio", Settings.Default.id_Ame2);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer4, "id_Amelio", Settings.Default.id_Ame3);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo4, "id_Amelio", Settings.Default.id_Ame3);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec4, "id_Amelio", Settings.Default.id_Ame3);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm4, "id_Amelio", Settings.Default.id_Ame3);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres4, "id_Amelio", Settings.Default.id_Ame3);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer5, "id_Amelio", Settings.Default.id_Ame4);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo5, "id_Amelio", Settings.Default.id_Ame4);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec5, "id_Amelio", Settings.Default.id_Ame4);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm5, "id_Amelio", Settings.Default.id_Ame4);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres5, "id_Amelio", Settings.Default.id_Ame4);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer6, "id_Amelio", Settings.Default.id_Ame5);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo6, "id_Amelio", Settings.Default.id_Ame5);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec6, "id_Amelio", Settings.Default.id_Ame5);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm6, "id_Amelio", Settings.Default.id_Ame5);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres6, "id_Amelio", Settings.Default.id_Ame5);
                crud.updateMultiRows("T_Amelioration", "exercice", _AmExer7, "id_Amelio", Settings.Default.id_Ame6);
                crud.updateMultiRows("T_Amelioration", "promotion", _Promo7, "id_Amelio", Settings.Default.id_Ame6);
                crud.updateMultiRows("T_Amelioration", "reaffec", _Reaffec7, "id_Amelio", Settings.Default.id_Ame6);
                crud.updateMultiRows("T_Amelioration", "formation", _AmForm7, "id_Amelio", Settings.Default.id_Ame6);
                crud.updateMultiRows("T_Amelioration", "autres", _AmAutres7, "id_Amelio", Settings.Default.id_Ame6);

                crud.crudop("update T_FinContrat set contrat='" + _Contract + "',date_Renouv='" + _ContDate + "',date_Notif='" + _ConNotif + "',nRef='" + _ConRef + "' where id_Emp='" + _Mat + "'");
               
                if (_deparCateg != "")
                {
                    crud.crudop("update T_Contrat set Etat=Null where id_Emp='" + _Mat + "'");
                }
                crud.crudop("update T_Depart set date_Depa='" + _deparDate + "',cate_Dep='" + _deparCateg + "',cause_Dep='" + _deparCause + "',autreCause='" + _autreCause + "' where id_Emp='" + _Mat + "'");

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Modification de fiche de renseignement','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Recruit_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            txtUser.Text = dashboard.lblName.Text;

            UserControls.UC_CivilState c_CivilState = new UserControls.UC_CivilState();
            someMat = new fNameFunction(someOtherName);
            c_CivilState.Mat = someMat;

            UserControls.UC_Military c_Military = new UserControls.UC_Military();
            someMat1 = new fNameFunction1(someOtherName1);
            c_Military.Mat1 = someMat1;

            UserControls.UC_StudyLevel c_StudyLevel = new UserControls.UC_StudyLevel();
            someMat2 = new fNameFunction2(someOtherName2);
            c_StudyLevel.Mat2 = someMat2;

            UserControls.UC_ProfStudy c_ProfStudy = new UserControls.UC_ProfStudy();
            someMat3 = new fNameFunction3(someOtherName3);
            c_ProfStudy.Mat3 = someMat3;

            UserControls.UC_Trainings c_Trainings = new UserControls.UC_Trainings();
            someMat4 = new fNameFunction4(someOtherName4);
            c_Trainings.Mat4 = someMat4;

            UserControls.UC_Career c_Career = new UserControls.UC_Career();
            someMat5 = new fNameFunction5(someOtherName5);
            c_Career.Mat5 = someMat5;

            UserControls.UC_Language c_Language = new UserControls.UC_Language();
            someMat6 = new fNameFunction6(someOtherName6);
            c_Language.Mat6 = someMat6;

            UserControls.UC_Software c_Software = new UserControls.UC_Software();
            someMat7 = new fNameFunction7(someOtherName7);
            c_Software.Mat7 = someMat7;

            UserControls.UC_Projects c_Projects = new UserControls.UC_Projects();
            someMat8 = new fNameFunction8(someOtherName8);
            c_Projects.Mat8 = someMat8;

            UserControls.UC_Intersets c_Intersets = new UserControls.UC_Intersets();
            someMat9 = new fNameFunction9(someOtherName9);
            c_Intersets.Mat9 = someMat9;

            UserControls.UC_RequestOrigine c_RequestOrigine = new UserControls.UC_RequestOrigine();
            someMat10 = new fNameFunction10(someOtherName10);
            c_RequestOrigine.Mat10 = someMat10;

            UserControls.UC_DoYouKnow c_DoYouKnow = new UserControls.UC_DoYouKnow();
            someMat11 = new fNameFunction11(someOtherName11);
            c_DoYouKnow.Mat11 = someMat11;

            UserControls.UC_Medecin c_Medecin = new UserControls.UC_Medecin();
            someMat12 = new fNameFunction12(someOtherName12);
            c_Medecin.Mat12 = someMat12;

            UserControls.UC_ContractInfo c_ContractInfo = new UserControls.UC_ContractInfo();
            someMat13 = new fNameFunction13(someOtherName13);
            c_ContractInfo.Mat13 = someMat13;

            UserControls.UC_Rewards c_Rewards = new UserControls.UC_Rewards();
            someMat14 = new fNameFunction14(someOtherName14);
            c_Rewards.Mat14 = someMat14;

            UserControls.UC_TrialPeriod c_TrialPeriod = new UserControls.UC_TrialPeriod();
            someMat15 = new fNameFunction15(someOtherName15);
            c_TrialPeriod.Mat15 = someMat15;

            UserControls.UC_FormationCSC c_FormationCSC = new UserControls.UC_FormationCSC();
            someMat16 = new fNameFunction16(someOtherName16);
            c_FormationCSC.Mat16 = someMat16;

            UserControls.UC_Discipline c_Discipline = new UserControls.UC_Discipline();
            someMat17 = new fNameFunction17(someOtherName17);
            c_Discipline.Mat17 = someMat17;

            UserControls.UC_Surveillance c_Surveillance = new UserControls.UC_Surveillance();
            someMat18 = new fNameFunction18(someOtherName18);
            c_Surveillance.Mat18 = someMat18;

            UserControls.UC_Evaluation c_Evaluation = new UserControls.UC_Evaluation();
            someMat19 = new fNameFunction19(someOtherName19);
            c_Evaluation.Mat19 = someMat19;

            UserControls.UC_Emprovement c_Emprovement = new UserControls.UC_Emprovement();
            someMat20 = new fNameFunction20(someOtherName20);
            c_Emprovement.Mat20 = someMat20;

            UserControls.UC_EndContract c_EndContract = new UserControls.UC_EndContract();
            someMat21 = new fNameFunction21(someOtherName21);
            c_EndContract.Mat21 = someMat21;

            UserControls.UC_Leave c_Leave = new UserControls.UC_Leave();
            someMat22 = new fNameFunction22(someOtherName22);
            c_Leave.Mat22 = someMat22;

            AddControlsToPanel(c_Leave);
            AddControlsToPanel(c_EndContract);
            AddControlsToPanel(c_Emprovement);
            AddControlsToPanel(c_Evaluation);
            AddControlsToPanel(c_Surveillance);
            AddControlsToPanel(c_Discipline);
            AddControlsToPanel(c_FormationCSC);
            AddControlsToPanel(c_TrialPeriod);
            AddControlsToPanel(c_Rewards);
            AddControlsToPanel(c_ContractInfo);
            AddControlsToPanel(c_Medecin);
            AddControlsToPanel(c_DoYouKnow);
            AddControlsToPanel(c_RequestOrigine);
            AddControlsToPanel(c_Intersets);
            AddControlsToPanel(c_Software);
            AddControlsToPanel(c_Language);
            AddControlsToPanel(c_Career);
            AddControlsToPanel(c_Trainings);
            AddControlsToPanel(c_ProfStudy);
            AddControlsToPanel(c_StudyLevel);
            AddControlsToPanel(c_Military);
            AddControlsToPanel(c_CivilState);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            UserControls.UC_Leave c_Leave = new UserControls.UC_Leave();
            someMat22 = new fNameFunction22(someOtherName22);
            c_Leave.Mat22 = someMat22;
            AddControlsToPanel(c_Leave);
        }
    }
}
