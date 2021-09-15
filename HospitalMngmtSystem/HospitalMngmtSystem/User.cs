using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMngmtSystem
{
    class User
    {
        public int UserId, RoleId;  //Physician, Nurse, Admin
        public byte Age;
        public string Title, FirstName, LastName, EmailId, DOB, Password;


        public void Register()
        {
            //registering the user with corresponding details to the system 
        }

        public void Login()
        {
            //Login the user to the system
        }
        public void ForgotPwd()
        {
            //Forgot pwd to retain the password
        }

        public void ChangePwd()
        {
            //change pwd
        }

        public void ViewDetails()
        {
            //change pwd
        }

    }
        // Derived class : Admin from User Class
        class Admin : User
        {
            public void AddDoctors()
            {
                // adding doctors or staffs to the hospital
            }
            public void ViewUserDetails()
            {
                // view details of the user
            }

            public void AddDepartments()
            {
                // adding new departments to the hospital
            }

            public void ManageInbox()
            {
                //manage messages in inboxes
            }
            public void ApproveRequestFromPatients()
            {
                //manage messages in inboxes
            }

        }

        // Derived class : Nurse from User Class
        class Nurse : User
        {
            public string Department;
            public void ServePatients()
            {
                // Serve Patients
            }
            public void ViewInbox()
            {
                // view details of the user
            }

            public void SendMessage()
            {
                // adding new departments to the hospital
            }

        }


        // Derived class : Patient from User Class
        class Patient : User
        {
            public string HomeAddress, ContactNumber, EmergencyContactId;

            public void RequestAppointment()
            {
                // Requesting appointments
            }
            public void UpdateDetails()
            {
                // update existing details in the portal
            }

            public void CancelAppointment()
            {
                // adding new departments to the hospital
            }

            public void ExportData()
            {
                //export existing data
            }

            public void ViewAppointmentDetails()
            {
                 // view the details of appointments
            }

        }



        // Derived class : Doctor from User Class
        class Doctor : User
        {
            public string Department, Specialisation, designation;
            public void ViewAppointmentRequests()
            {
                //
            }

            public void ScheduleAppointments()
            {
                //
            }

            public void ManageAppointments()
            {
                //
            }
            public void UpdatePatientVitals()
            {
                //
            }
            
            public void ProvideDiagnosisDetails()
            {
                  //update diagonis details, medications, description of condition etc...
            }


        public void ViewInbox()
            {
                // view inbox
            }

            public void SendMessage()
            {
                
            }

            public void ViewCalender()
            {
               // view calender
            }

          

        }

    //derived class dependents from user

    class Dependents : User
    {
        public int Did;
        public bool Patient_Info_Status;
        public string Address;
        public void ViewPatientInfo()
        {
            // view info from portal
        }


    }



    
}
