using System;
using System.Collections.Generic;
using System.Text;

namespace CallBillingGeneration
{
    public class Client
    {
        private string person;
        private ClientType type;
        private ICallPlan plan;

        public Client(string person, ClientType typeClient) {

            this.person = person;
            this.type = typeClient;
            _setPlan();
        }
        public  string Person
        {
            get { return this.person; }   
            set { this.person = value; }  
        }
        public ClientType Type 
        {
            get { return this.type; }
            set { _setType(value); }
        }
        public ICallPlan Plan
        {
            get { return this.plan; }
           
        }

        private void _setPlan() {
            if(string.Equals(this.type, ClientType.New))
            {
                this.plan = new NewClientPlan();
            }

            if (string.Equals(this.type, ClientType.Existing))
            {
                this.plan = new ClassicPlan();
            }
        }

        private void _setType(ClientType type)
        {
            this.type = type;
            _setPlan();
        }
    }
}
