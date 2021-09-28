using System;
using System.Collections;
using System.Text;

namespace Week7_Task1
{
    /*     * Id : sistem terefinden genarete olunacaq , set oluna bilmez, 1-den baslayaraq artan olmalidir.
           * Barcode : DataBase-de eyni barcode-a sahip mehsulun olub olmamasi yoxlanmalidir.
           * Purchase price : mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.
           * Sale price : mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.
           * Discount price : mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.
           * CreateDate : set edile bilmez.
           * Brand
           * Model
           * IsDeleted (bool)
           * DeletedDate : set edile bilmez
           * UpdatedDate : set edile bilmez
*/

    public abstract class Product : BaseEntity
    {


        #region fields


        private string _barcode;
        private int _salePrice;
        private int _purchasePrice;
        private int _discountPrice;
        private DateTime _createDate;
        private string _brand;
        private string _model;
        private bool _isDeleted;
        protected DateTime _deletedDate;
        protected DateTime _updatedDate;

        #endregion

        #region Prop


        public string Barcode
        {
            get { return _barcode; }
            set
            {


                _barcode = value;

            }
        }

        public int PurchasePrice
        {
            get { return _purchasePrice; }
            set
            {
                if (PurchasePrice <= 0)
                {
                    Console.WriteLine("Mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez");
                }

                else
                {
                    _purchasePrice = value;
                }
            }
        }

        public int SalePrice
        {
            get { return _salePrice; }
            set
            {
                if (this._purchasePrice > SalePrice)
                {
                    Console.WriteLine("Mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.");
                }
                else
                {
                    _salePrice = value;
                }
            }
        }
        public int DiscountPrice
        {
            get { return _discountPrice; }
            set
            {
                if (DiscountPrice <= 0)
                {
                    Console.WriteLine("Mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez");
                }
                else
                {
                    _discountPrice = value;
                }
            }
        }
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public DateTime DeletedDate
        {
            get { return _deletedDate; }
        }

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
        }
        #endregion




    }
}
