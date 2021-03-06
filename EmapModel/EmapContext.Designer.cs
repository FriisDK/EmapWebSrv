//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 30-08-2021 20:50:58
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace EMAPContext
{

    [DatabaseAttribute(Name = "EMAP")]
    [ProviderAttribute(typeof(Devart.Data.Oracle.Linq.Provider.OracleDataProvider))]
    public partial class EMAPDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(EMAPDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertLICENSER(LICENSER instance);
        partial void UpdateLICENSER(LICENSER instance);
        partial void DeleteLICENSER(LICENSER instance);
        partial void InsertLYRIC(LYRIC instance);
        partial void UpdateLYRIC(LYRIC instance);
        partial void DeleteLYRIC(LYRIC instance);

        #endregion

        public EMAPDataContext() :
        base(@"User Id=emap;Password=efj7185;Server=localhost;Direct=True;Service Name=orcl;Port=10521;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public EMAPDataContext(MappingSource mappingSource) :
        base(@"User Id=emap;Password=efj7185;Server=localhost;Direct=True;Service Name=orcl;Port=10521;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public EMAPDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public EMAPDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public EMAPDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public EMAPDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<LICENSER> LICENSERs
        {
            get
            {
                return this.GetTable<LICENSER>();
            }
        }

        public Devart.Data.Linq.Table<LYRIC> LYRICs
        {
            get
            {
                return this.GetTable<LYRIC>();
            }
        }
    }
}

namespace EMAPContext
{

    /// <summary>
    /// There are no comments for EMAPContext.LICENSER in the schema.
    /// </summary>
    [Table(Name = @"EMAP.LICENSER")]
    public partial class LICENSER : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private string _PRGID;

        private string _CPUID1;

        private string _CPUID2;

        private string _CPUID3;

        private string _CUSTNAME;

        private string _CUSTADD;

        private string _CUSTADD1;

        private string _CUSTZIP;

        private string _CUSTCITY;

        private string _CUSTCOUNTRY;

        private string _CUSTEMAIL;

        private string _GENREG;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnPRGIDChanging(string value);
        partial void OnPRGIDChanged();
        partial void OnCPUID1Changing(string value);
        partial void OnCPUID1Changed();
        partial void OnCPUID2Changing(string value);
        partial void OnCPUID2Changed();
        partial void OnCPUID3Changing(string value);
        partial void OnCPUID3Changed();
        partial void OnCUSTNAMEChanging(string value);
        partial void OnCUSTNAMEChanged();
        partial void OnCUSTADDChanging(string value);
        partial void OnCUSTADDChanged();
        partial void OnCUSTADD1Changing(string value);
        partial void OnCUSTADD1Changed();
        partial void OnCUSTZIPChanging(string value);
        partial void OnCUSTZIPChanged();
        partial void OnCUSTCITYChanging(string value);
        partial void OnCUSTCITYChanged();
        partial void OnCUSTCOUNTRYChanging(string value);
        partial void OnCUSTCOUNTRYChanged();
        partial void OnCUSTEMAILChanging(string value);
        partial void OnCUSTEMAILChanged();
        partial void OnGENREGChanging(string value);
        partial void OnGENREGChanged();
        #endregion

        public LICENSER()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for PRGID in the schema.
        /// </summary>
        [Column(Name = @"PRG_ID", Storage = "_PRGID", CanBeNull = false, DbType = "VARCHAR2(200 CHAR) NOT NULL", IsPrimaryKey = true)]
        public string PRGID
        {
            get
            {
                return this._PRGID;
            }
            set
            {
                if (this._PRGID != value)
                {
                    this.OnPRGIDChanging(value);
                    this.SendPropertyChanging("PRGID");
                    this._PRGID = value;
                    this.SendPropertyChanged("PRGID");
                    this.OnPRGIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CPUID1 in the schema.
        /// </summary>
        [Column(Name = @"CPU_ID_1", Storage = "_CPUID1", DbType = "VARCHAR2(200 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CPUID1
        {
            get
            {
                return this._CPUID1;
            }
            set
            {
                if (this._CPUID1 != value)
                {
                    this.OnCPUID1Changing(value);
                    this.SendPropertyChanging("CPUID1");
                    this._CPUID1 = value;
                    this.SendPropertyChanged("CPUID1");
                    this.OnCPUID1Changed();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CPUID2 in the schema.
        /// </summary>
        [Column(Name = @"CPU_ID_2", Storage = "_CPUID2", DbType = "VARCHAR2(200 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CPUID2
        {
            get
            {
                return this._CPUID2;
            }
            set
            {
                if (this._CPUID2 != value)
                {
                    this.OnCPUID2Changing(value);
                    this.SendPropertyChanging("CPUID2");
                    this._CPUID2 = value;
                    this.SendPropertyChanged("CPUID2");
                    this.OnCPUID2Changed();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CPUID3 in the schema.
        /// </summary>
        [Column(Name = @"CPU_ID_3", Storage = "_CPUID3", DbType = "VARCHAR2(200 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CPUID3
        {
            get
            {
                return this._CPUID3;
            }
            set
            {
                if (this._CPUID3 != value)
                {
                    this.OnCPUID3Changing(value);
                    this.SendPropertyChanging("CPUID3");
                    this._CPUID3 = value;
                    this.SendPropertyChanged("CPUID3");
                    this.OnCPUID3Changed();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTNAME in the schema.
        /// </summary>
        [Column(Name = @"CUST_NAME", Storage = "_CUSTNAME", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTNAME
        {
            get
            {
                return this._CUSTNAME;
            }
            set
            {
                if (this._CUSTNAME != value)
                {
                    this.OnCUSTNAMEChanging(value);
                    this.SendPropertyChanging("CUSTNAME");
                    this._CUSTNAME = value;
                    this.SendPropertyChanged("CUSTNAME");
                    this.OnCUSTNAMEChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTADD in the schema.
        /// </summary>
        [Column(Name = @"CUST_ADD", Storage = "_CUSTADD", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTADD
        {
            get
            {
                return this._CUSTADD;
            }
            set
            {
                if (this._CUSTADD != value)
                {
                    this.OnCUSTADDChanging(value);
                    this.SendPropertyChanging("CUSTADD");
                    this._CUSTADD = value;
                    this.SendPropertyChanged("CUSTADD");
                    this.OnCUSTADDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTADD1 in the schema.
        /// </summary>
        [Column(Name = @"CUST_ADD_1", Storage = "_CUSTADD1", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTADD1
        {
            get
            {
                return this._CUSTADD1;
            }
            set
            {
                if (this._CUSTADD1 != value)
                {
                    this.OnCUSTADD1Changing(value);
                    this.SendPropertyChanging("CUSTADD1");
                    this._CUSTADD1 = value;
                    this.SendPropertyChanged("CUSTADD1");
                    this.OnCUSTADD1Changed();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTZIP in the schema.
        /// </summary>
        [Column(Name = @"CUST_ZIP", Storage = "_CUSTZIP", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTZIP
        {
            get
            {
                return this._CUSTZIP;
            }
            set
            {
                if (this._CUSTZIP != value)
                {
                    this.OnCUSTZIPChanging(value);
                    this.SendPropertyChanging("CUSTZIP");
                    this._CUSTZIP = value;
                    this.SendPropertyChanged("CUSTZIP");
                    this.OnCUSTZIPChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTCITY in the schema.
        /// </summary>
        [Column(Name = @"CUST_CITY", Storage = "_CUSTCITY", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTCITY
        {
            get
            {
                return this._CUSTCITY;
            }
            set
            {
                if (this._CUSTCITY != value)
                {
                    this.OnCUSTCITYChanging(value);
                    this.SendPropertyChanging("CUSTCITY");
                    this._CUSTCITY = value;
                    this.SendPropertyChanged("CUSTCITY");
                    this.OnCUSTCITYChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTCOUNTRY in the schema.
        /// </summary>
        [Column(Name = @"CUST_COUNTRY", Storage = "_CUSTCOUNTRY", DbType = "VARCHAR2(50 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTCOUNTRY
        {
            get
            {
                return this._CUSTCOUNTRY;
            }
            set
            {
                if (this._CUSTCOUNTRY != value)
                {
                    this.OnCUSTCOUNTRYChanging(value);
                    this.SendPropertyChanging("CUSTCOUNTRY");
                    this._CUSTCOUNTRY = value;
                    this.SendPropertyChanged("CUSTCOUNTRY");
                    this.OnCUSTCOUNTRYChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CUSTEMAIL in the schema.
        /// </summary>
        [Column(Name = @"CUST_EMAIL", Storage = "_CUSTEMAIL", DbType = "VARCHAR2(100 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string CUSTEMAIL
        {
            get
            {
                return this._CUSTEMAIL;
            }
            set
            {
                if (this._CUSTEMAIL != value)
                {
                    this.OnCUSTEMAILChanging(value);
                    this.SendPropertyChanging("CUSTEMAIL");
                    this._CUSTEMAIL = value;
                    this.SendPropertyChanged("CUSTEMAIL");
                    this.OnCUSTEMAILChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for GENREG in the schema.
        /// </summary>
        [Column(Storage = "_GENREG", DbType = "VARCHAR2(1 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string GENREG
        {
            get
            {
                return this._GENREG;
            }
            set
            {
                if (this._GENREG != value)
                {
                    this.OnGENREGChanging(value);
                    this.SendPropertyChanging("GENREG");
                    this._GENREG = value;
                    this.SendPropertyChanged("GENREG");
                    this.OnGENREGChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for EMAPContext.LYRIC in the schema.
    /// </summary>
    [Table(Name = @"EMAP.LYRIC")]
    public partial class LYRIC : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _UNIQUEID;

        private string _TITLE;

        private string _LYRIC1;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnUNIQUEIDChanging(int value);
        partial void OnUNIQUEIDChanged();
        partial void OnTITLEChanging(string value);
        partial void OnTITLEChanged();
        partial void OnLYRIC1Changing(string value);
        partial void OnLYRIC1Changed();
        #endregion

        public LYRIC()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for UNIQUEID in the schema.
        /// </summary>
        [Column(Name = @"UNIQUE_ID", Storage = "_UNIQUEID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "NUMBER NULL", IsDbGenerated = true, IsPrimaryKey = true)]
        [Devart.Data.Linq.Mapping.SequenceGenerator(Sequence = "lyric#unique_id")]
        public int UNIQUEID
        {
            get
            {
                return this._UNIQUEID;
            }
            set
            {
                if (this._UNIQUEID != value)
                {
                    this.OnUNIQUEIDChanging(value);
                    this.SendPropertyChanging("UNIQUEID");
                    this._UNIQUEID = value;
                    this.SendPropertyChanged("UNIQUEID");
                    this.OnUNIQUEIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for TITLE in the schema.
        /// </summary>
        [Column(Storage = "_TITLE", DbType = "VARCHAR2(1000 CHAR) NULL", UpdateCheck = UpdateCheck.Never)]
        public string TITLE
        {
            get
            {
                return this._TITLE;
            }
            set
            {
                if (this._TITLE != value)
                {
                    this.OnTITLEChanging(value);
                    this.SendPropertyChanging("TITLE");
                    this._TITLE = value;
                    this.SendPropertyChanged("TITLE");
                    this.OnTITLEChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for LYRIC1 in the schema.
        /// </summary>
        [Column(Name = @"LYRIC", Storage = "_LYRIC1", DbType = "CLOB NULL", UpdateCheck = UpdateCheck.Never)]
        public string LYRIC1
        {
            get
            {
                return this._LYRIC1;
            }
            set
            {
                if (this._LYRIC1 != value)
                {
                    this.OnLYRIC1Changing(value);
                    this.SendPropertyChanging("LYRIC1");
                    this._LYRIC1 = value;
                    this.SendPropertyChanged("LYRIC1");
                    this.OnLYRIC1Changed();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
