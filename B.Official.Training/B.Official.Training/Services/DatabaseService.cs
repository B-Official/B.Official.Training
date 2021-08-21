﻿using System;
using System.IO;
using System.Threading.Tasks;
using B.Official.Training.Models;
using SQLite;

namespace B.Official.Training.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _sqLite;
        private const SQLite.SQLiteOpenFlags _flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
        public DatabaseService()
        {
            _sqLite = new SQLiteAsyncConnection(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"database.db3"), _flags);
            _sqLite.CreateTableAsync<UserModel>();
        }
        /// <summary>
        /// đăng ký tài khoản
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> RegisterAccount(UserModel user)
        {
            return await _sqLite.InsertAsync(user) == 1;
        }
        /// <summary>
        /// đăng nhập
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserModel> Login(UserModel user)
        {
            var data = await _sqLite.FindAsync<UserModel>(user.UserName);
            if (data != null)
            {
                if (data.Password == user.Password)
                {
                    return data;
                }
            }
            return null;
        }
    }
}