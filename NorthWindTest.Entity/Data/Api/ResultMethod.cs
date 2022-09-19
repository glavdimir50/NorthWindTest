using System.Threading.Tasks;

namespace NorthWindTest.Entity.Data.Api
{
    public static class ResultMethod
    {
        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public async static Task<Result<bool>> SuccessAsync()
        {
            return await Task.Run(() =>
            {
                Result<bool> result = new Result<bool>();
                result.OK = true;
                result.Model = true;
                result.ResponseCode = ResponseCode.Success;
                result.Message = ResponseCodeDescription.GetMessage[ResponseCode.Success];
                return result;
            });
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public async static Task<Result<T>> SuccessAsync<T>(T model)
        {
            return await Task.Run(() =>
            {
                Result<T> result = new Result<T>();
                result.OK = true;
                result.Model = model;
                result.ResponseCode = ResponseCode.Success;
                result.Message = ResponseCodeDescription.GetMessage[ResponseCode.Success];
                return result;
            });
        }

        /// <summary>
        /// 失敗
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public async static Task<Result<bool>> ErrorAsync(string errorCode)
        {
            return await Task.Run(() =>
            {
                Result<bool> result = new Result<bool>();
                result.OK = false;
                result.Model = false;
                result.ResponseCode = errorCode;
                result.Message = ResponseCodeDescription.GetMessage[errorCode];
                return result;
            });
        }

        /// <summary>
        /// 失敗
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public async static Task<Result<T>> ErrorAsync<T>(string errorCode)
        {
            return await Task.Run(() =>
            {
                Result<T> result = new Result<T>();
                result.OK = false;
                result.ResponseCode = errorCode;
                result.Message = ResponseCodeDescription.GetMessage[errorCode];
                return result;
            });
        }
    }
}
