using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.Data.Api
{
    public class ResultMethod
    {
        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static Result<bool> Success()
        {
            Result<bool> result = new Result<bool>();
            result.OK = true;
            result.Model = true;
            result.ResponseCode = ResponseCode.Success;
            result.Message = ResponseCodeDescription.GetMessage[ResponseCode.Success];
            return result;
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Result<T> Success<T>(T model)
        {
            Result<T> result = new Result<T>();
            result.OK = true;
            result.Model = model;
            result.ResponseCode = ResponseCode.Success;
            result.Message = ResponseCodeDescription.GetMessage[ResponseCode.Success];
            return result;
        }

        /// <summary>
        /// 失敗
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static Result<bool> Error(string errorCode)
        {
            Result<bool> result = new Result<bool>();
            result.OK = false;
            result.Model = false;
            result.ResponseCode = errorCode;
            result.Message = ResponseCodeDescription.GetMessage[errorCode];
            return result;
        }

        /// <summary>
        /// 失敗
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static Result<T> Error<T>(string errorCode)
        {
            Result<T> result = new Result<T>();
            result.OK = false;
            result.ResponseCode = errorCode;
            result.Message = ResponseCodeDescription.GetMessage[errorCode];
            return result;
        }
    }
}
