using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Archiving
{
    public class DataParam : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string Title { get; set; }
        public string Tag { get; set; }
        public string TypeOfReports { get; set; }

        private string value = "";
        public string Value
        {
            get { return value; }
            set
            {
                this.value = value.ToString();
                OnPropertyChanged("Value");
            }
        }

        private ObservableCollection<DataParam> variations = new ObservableCollection<DataParam>();
        public ObservableCollection<DataParam> Variations
        {
            get { return variations; }
            set { variations = value; }
        }
    }

    public class TTN : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private DataParam id = new DataParam() { Title = "id" };
        public DataParam Id { get { return id; } }

        private DataParam date = new DataParam() { Title = "Дата", Tag="<DATE>", TypeOfReports="6" };
        public DataParam Date { get { return date; } }

        private DataParam poured_m = new DataParam() { Title = "Доза м3" };
        public DataParam PouredM { get { return poured_m; } }

        private DataParam poured_t = new DataParam() { Title = "Доза т" };
        public DataParam PouredT { get { return poured_t; } }

        private DataParam netto_m = new DataParam() { Title = "Нетто м3" };
        public DataParam NettoM { get { return netto_m; } }

        private DataParam netto_t = new DataParam() { Title = "Нетто т", Tag="<NETTO_T>", TypeOfReports="6" };
        public DataParam NettoT { get { return netto_t; } }

        private DataParam ballast_m = new DataParam() { Title = "Балласт м3" };
        public DataParam BallastM { get { return ballast_m; } }

        private DataParam ballast_t = new DataParam() { Title = "Балласт т" };
        public DataParam BallastT { get { return ballast_t; } }

        private DataParam temp = new DataParam() { Title = "Температура" };
        public DataParam Temp { get { return temp; } }

        private DataParam density = new DataParam() { Title = "Плотность" };
        public DataParam Density { get { return density; } }

        private DataParam humidity = new DataParam() { Title = "Влажность" };
        public DataParam Humidity { get { return humidity; } }

        private DataParam part_water = new DataParam() { Title = "Доля воды" };
        public DataParam PartWater { get { return part_water; } }

        private DataParam part_imp = new DataParam() { Title = "Доля примесей" };
        public DataParam PartImp { get { return part_imp; } }

        private DataParam part_salt = new DataParam() { Title = "Доля солей" };
        public DataParam PartSalt { get { return part_salt; } }

        private DataParam sender = new DataParam() { Title = "Грузоотправитель", Tag="<SENDER>", TypeOfReports="6" };
        public DataParam Sender { get { return sender; } }

        private DataParam senderOkpo = new DataParam() { Title = "Грузоотправитель ОКПО" };
        public DataParam SenderOkpo { get { return senderOkpo; } }

        private DataParam senderOkpd = new DataParam() { Title = "Грузоотправитель ОКПД" };
        public DataParam SenderOkpd { get { return senderOkpd; } }

        private DataParam recipient = new DataParam() { Title = "Грузополучатель", Tag="<RECIPIENT>", TypeOfReports="6" };
        public DataParam Recipient { get { return recipient; } }

        private DataParam recipientOkpo = new DataParam() { Title = "Грузополучатель ОКПО" };
        public DataParam RecipientOkpo { get { return recipientOkpo; } }

        private DataParam supplier = new DataParam() { Title = "Поставщик" };
        public DataParam Supplier { get { return supplier; } }

        private DataParam supplierOkpo = new DataParam() { Title = "Поставщик ОКПО" };
        public DataParam SupplierOkpo { get { return supplierOkpo; } }

        private DataParam payer = new DataParam() { Title = "Плательщик" };
        public DataParam Payer { get { return payer; } }

        private DataParam payerOkpo = new DataParam() { Title = "Плательщик ОКПО" };
        public DataParam PayerOkpo { get { return payerOkpo; } }

        private DataParam basis = new DataParam() { Title = "Основание" };
        public DataParam Basis { get { return basis; } }

        private DataParam basisN = new DataParam() { Title = "Основание номер" };
        public DataParam BasisN { get { return basisN; } }

        private DataParam basisDate = new DataParam() { Title = "Основание дата" };
        public DataParam BasisDate { get { return basisDate; } }

        private DataParam ttnN = new DataParam() { Title = "Номер ТН", Tag="<TN_NUMBER>", TypeOfReports="6" };
        public DataParam TtnN { get { return ttnN; } }

        private DataParam torgN = new DataParam() { Title = "Номер торг12" };
        public DataParam TorgN { get { return torgN; } }

        private DataParam name = new DataParam() { Title = "Название товара", Tag="<NAME>", TypeOfReports="6" };
        public DataParam Name { get { return name; } }

        private DataParam code = new DataParam() { Title = "Код товара" };
        public DataParam Code { get { return code; } }

        private DataParam measure_name = new DataParam() { Title = "Наимен. ед. из." };
        public DataParam MeasureName { get { return measure_name; } }

        private DataParam measure_code = new DataParam() { Title = "Код ед. из." };
        public DataParam MeasureCode { get { return measure_code; } }

        private DataParam count_in_one = new DataParam() { Title = "Кол-во в одном месте" };
        public DataParam CountInOne { get { return count_in_one; } }

        private DataParam count_seats = new DataParam() { Title = "Кол-во мест", Tag="<COUNT_SEATS>", TypeOfReports="6" };
        public DataParam CountSeats { get { return count_seats; } }

        private DataParam price = new DataParam() { Title = "Цена" };
        public DataParam Price { get { return price; } }

        private DataParam nds_rate = new DataParam() { Title = "НДС, ставка" };
        public DataParam NdsRate { get { return nds_rate; } }

        private DataParam proxy_n = new DataParam() { Title = "Доверенность номер" };
        public DataParam ProxyN { get { return proxy_n; } }

        private DataParam proxy_date = new DataParam() { Title = "Доверенность дата" };
        public DataParam ProxyDate { get { return proxy_date; } }

        private DataParam proxy_company = new DataParam() { Title = "Доверенность  организация" };
        public DataParam ProxyCompany { get { return proxy_company; } }


        //РАЗОВЫЙ ТАЛОН НА ОТПУСК НЕФТИ
        private DataParam date_coupone = new DataParam() { Title = "Дата выдачи талона", Tag = "<DATE>", TypeOfReports =  "56"  };
        public DataParam DateCoupone { get { return date_coupone; } }

        private DataParam oil_coupone_number = new DataParam() { Title = "Номер разового талона", Tag = "<OIL_COUPONE_NUMBER>", TypeOfReports = "5" };
        public DataParam OilCouponeNumber { get { return oil_coupone_number; } }

        private DataParam workshop = new DataParam() { Title = "Номер цеха", Tag= "<WORKSHOP>", TypeOfReports="5" };
        public DataParam Workshop { get { return workshop; } }

        private DataParam car_number = new DataParam() { Title = "Номер машины", Tag = "<CAR_NUMBER>", TypeOfReports = "5" };
        public DataParam CarNumber { get { return car_number; } }

        private DataParam oil_point = new DataParam() { Title = "Пункт отпуска нефти", Tag = "<OIL_POINT>", TypeOfReports = "5" };
        public DataParam OilPoint { get { return oil_point; } }

        private DataParam oil_field = new DataParam() { Title = "Месторождение", Tag = "<OIL_FIELD>", TypeOfReports = "5" };
        public DataParam OilField { get { return oil_field; } }

        private DataParam well_number = new DataParam() { Title = "Номер скважины", Tag = "<WELL_NUMBER>", TypeOfReports = "5" };
        public DataParam WellNumber { get { return well_number; } }

        private DataParam tube_number = new DataParam() { Title = "Номер трубопровода", Tag = "<TUBE_NUMBER>", TypeOfReports = "5" };
        public DataParam TubeNumber { get { return tube_number; } }

        private DataParam type_of_work = new DataParam() { Title = "Тип работ", Tag = "<TYPE OF_WORK>", TypeOfReports = "5" };
        public DataParam TypeOfWork { get { return type_of_work; } }

        private DataParam requsted = new DataParam() { Title = "Затребовал", Tag = "<REQUESTED>", TypeOfReports = "5" };
        public DataParam Requsted { get { return requsted; } }

        private DataParam amount_of_tonns = new DataParam() { Title = "Количество тонн", Tag = "<AMOUNT_OF_TONNS>", TypeOfReports = "5" };
        public DataParam AmountOfTonns { get { return amount_of_tonns; } }

        private DataParam security_init = new DataParam() { Title = "Отметка  работника охраны ЧОП", Tag = "<SECURITY_INIT>", TypeOfReports = "5" };
        public DataParam SecurityInit { get { return security_init; } }

        private DataParam prohibited_init1 = new DataParam() { Title = "Разрешил 1", Tag = "<PROHIBITED_INIT1>", TypeOfReports = "5" };
        public DataParam ProhibitedInit1 { get { return prohibited_init1; } }

        private DataParam prohibited_init2 = new DataParam() { Title = "Разрешил 2", Tag = "<PROHIBITED_INIT2>", TypeOfReports = "5" };
        public DataParam ProhibitedInit2 { get { return prohibited_init2; } }

        private DataParam operator_init = new DataParam() { Title = "Оператор", Tag = "<OPERATOR_INIT>", TypeOfReports = "5" };
        public DataParam OperatorInit { get { return operator_init; } }

        private DataParam driver_init = new DataParam() { Title = "Водитель", Tag = "<RECIEVER_INIT>", TypeOfReports = "5" };
        public DataParam DriverInit { get { return driver_init; } }

        //ПРИЛОЖЕНИЕ 6 ТРАНСПОРТНАЯ НАКЛАДНАЯ НА ОТПУСК НЕФТИ СТОРОННИМ ОРГАНИЗАЦИЯМ И НА СН

        private DataParam reciever_init= new DataParam() { Title = "Водитель", Tag = "<RECIEVER_INIT>", TypeOfReports = "6" };
        public DataParam RecieverInit { get { return reciever_init; } }

        //nene 


    }
}