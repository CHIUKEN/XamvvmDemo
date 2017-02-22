using System;
using System.Collections.ObjectModel;
using Xamvvm;

namespace XamvvmDemo
{
	public class DataListPageModel: BasePageModel
	{
		public DataListPageModel() 
		{
			GetData();
		}


		public void GetData()
		{
			Items = new ObservableCollection<ItemModel>();
			var model1 = new ItemModel() { Name = "Taipei", City = "臺北" };
			var model2 = new ItemModel() { Name = "New North City", City = "新北市" };
			var model3 = new ItemModel() { Name = "Taoyuan", City = "桃園" };
			var model4 = new ItemModel() { Name = "Hsinchu", City = "新竹市" };
			var model5 = new ItemModel() { Name = "Miaoli", City = "苗栗" };

			Items.Add(model1);
			Items.Add(model2);
			Items.Add(model3);
			Items.Add(model4);
			Items.Add(model5);
		}

		public ObservableCollection<ItemModel> Items
		{
			get { return GetField<ObservableCollection<ItemModel>>(); }
			set { SetField(value); }
		}

		public class ItemModel : BaseModel
		{
			string name;
			public string Name
			{
				get { return name; }
				set { SetField(ref name, value); }
			}

			string city;
			public string City
			{
				get { return city; }
				set { SetField(ref city, value); }
			}
		}
	}
}
