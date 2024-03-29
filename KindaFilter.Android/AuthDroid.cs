﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using KindaFilter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.Gms.Extensions;
using KindaFilter.Droid;

//[assembly:Dependency(typeof(AuthDroid))]
//namespace KindaFilter.Droid
//{
//    public class AuthDroid : IAuth
//    {
//        public bool IsSignIn()
//        {
//            var user = FirebaseAuth.Instance.CurrentUser;
//            return user != null;
//        }

//        public async Task<string> LogInWithEmailAndPassword(string email, string password)
//        {
//            try
//            {
//                var newUser = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
//                var token = await FirebaseAuth.Instance.CurrentUser.GetIdToken(false).AsAsync<GetTokenResult>();
//                return token.Token;
//            }
//            catch (FirebaseAuthInvalidUserException e)
//            {

//                e.PrintStackTrace();
//                return string.Empty;
//            }
//            catch (FirebaseAuthInvalidCredentialsException e)
//            {

//                e.PrintStackTrace();
//                return string.Empty;
//            }
//        }

//        public bool SignOut()
//        {
//            try
//            {
//                FirebaseAuth.Instance.SignOut();
//                return true;
//            }
//            catch(Exception err)
//            {
//                Console.WriteLine(err.Message);
//                return false; 
//            }
//        }

//        public async Task<string> SignUpWithEmailAndPassword(string email, string password)
//        {
//            try
//            {
//                var newUser = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
//                var token = await (FirebaseAuth.Instance.CurrentUser.GetIdToken(false).AsAsync<GetTokenResult>());
//                return token.Token;
//            }
//            catch (FirebaseAuthInvalidUserException e)
//            {

//                e.PrintStackTrace();
//                return string.Empty;
//            }
//            catch (FirebaseAuthInvalidCredentialsException e)
//            {

//                e.PrintStackTrace();
//                return string.Empty;
//            }
//        }
//    }
//}