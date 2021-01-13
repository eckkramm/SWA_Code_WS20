using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMultiVmApp.ViewModel
{
    class PersonVm : ViewModelBase
    {
		private string firstname;
		private string lastname;
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; RaisePropertyChanged(); }
		}

		public string Lastname
		{
			get { return lastname; }
			set { lastname = value; RaisePropertyChanged(); }
		}

		public string Firstname
		{
			get { return firstname; }
			set { firstname = value; RaisePropertyChanged(); }
		}

	}
}
