using MauiAppDemo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.Services
{
    public class CarService
    {
        private SQLiteConnection conn;
        string _dbPath;
        string statusMessage;
        public CarService(string dbPath)
        {
                _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null) return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Car>();
        }
        public List<Car> GetCars()
        {
            try
            {
                Init();
                return conn.Table<Car>().ToList();  

            }
            catch (Exception ex)
            {

                statusMessage = "Failed to " + ex;
            }
            return new List<Car>();
        }
    }
}

