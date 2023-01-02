using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    internal class BLL
    {
        DAL dAL;
        SqlDataReader reader;

        public BLL()
        {
            dAL = new DAL();
        }

        public List<Transaction> GetTransactionList()
        {
            List<Transaction> transactions = new List<Transaction>();

            try
            {

                reader = dAL.GetTransactionList();
                while (reader.Read())
                {
                    transactions.Add(new Transaction()
                    {
                        SiraNo = reader.IsDBNull(0) ? -100 : reader.GetInt64(0),
                        MalKodu = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Tur = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        EvrakNo = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Tarih = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        GirisMiktar = reader.IsDBNull(5) ? -100 : reader.GetDecimal(5),
                        CikisMiktar = reader.IsDBNull(6) ? -100 : reader.GetDecimal(6)
                    });

                }
                
                for (int i = 0; i < transactions.Count; i++)
                {
                    decimal stok = 0;
                    foreach (var item in transactions)
                    {
                        if (item.Tur == "Giriş")
                        {
                            stok += item.GirisMiktar;
                        }

                        else
                        {
                            stok += item.CikisMiktar;
                        }
                        item.Stok = stok;
                    }
                
                    //item.Stok = stok;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dAL.SetConnect();
            }
            return transactions;
        }

        public List<Transaction> GetTransactionListByCode(string MalKodu)
        {

            List<Transaction> transactions = new List<Transaction>();
            decimal stok = 0;
            try
            {
                reader = dAL.GetTransactionListByCode(MalKodu);
                while (reader.Read())
                {
                    transactions.Add(new Transaction()
                    {
                        SiraNo = reader.IsDBNull(0) ? -100 : reader.GetInt64(0),
                        MalKodu = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Tur = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        EvrakNo = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Tarih = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        GirisMiktar = reader.IsDBNull(5) ? -100 : reader.GetDecimal(5),
                        CikisMiktar = reader.IsDBNull(6) ? -100 : reader.GetDecimal(6)
                    });

                }
                foreach (var item in transactions)
                {
                    if (item.Tur == "Giriş")
                        stok += item.GirisMiktar;
                    else
                        stok -= item.CikisMiktar;
                    item.Stok = stok;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dAL.SetConnect();
            }
            return transactions;
        }

        public List<Transaction> GetTransactionListByDate(int Tarih1, int Tarih2)
        {

            List<Transaction> transactions = new List<Transaction>();
            decimal stok = 0;
            try
            {
                reader = dAL.GetTransactionListByDate(Tarih1, Tarih2);
                while (reader.Read())
                {
                    transactions.Add(new Transaction()
                    {
                        SiraNo = reader.IsDBNull(0) ? -100 : reader.GetInt64(0),
                        MalKodu = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Tur = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        EvrakNo = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Tarih = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        GirisMiktar = reader.IsDBNull(5) ? -100 : reader.GetDecimal(5),
                        CikisMiktar = reader.IsDBNull(6) ? -100 : reader.GetDecimal(6)
                    });

                }
                foreach (var item in transactions)
                {
                    if (item.Tur == "Giriş")
                        stok += item.GirisMiktar;
                    else
                        stok -= item.CikisMiktar;
                    item.Stok = stok;
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dAL.SetConnect();
            }
            return transactions;
        }
    }
}
