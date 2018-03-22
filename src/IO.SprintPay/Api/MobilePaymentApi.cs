/* 
 * Sprint-pay payment for developper
 *
 * This is a sample doc to use our sprint-pay payment api.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: sprint-pay@sprint-pay.com
 * Generated by: https://github.com/SprintPay-api/SprintPay-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.SprintPay.Client;
using IO.SprintPay.Model;

namespace IO.SprintPay.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMobilePaymentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Make a new mobilemoney payment
        /// </summary>
        /// <remarks>
        /// Make an payment using MobileMoney
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>PaymentMobileReponse</returns>
        PaymentMobileReponse Mobilemoney(Orangemoney body);

        /// <summary>
        /// Make a new mobilemoney payment
        /// </summary>
        /// <remarks>
        /// Make an payment using MobileMoney
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        ApiResponse<PaymentMobileReponse> MobilemoneyWithHttpInfo(Orangemoney body);
        /// <summary>
        /// check the status of mobile payment request using processingNumber
        /// </summary>
        /// <remarks>
        /// processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>PaymentMobileReponse</returns>
        PaymentMobileReponse Mobilestatus(List<string> processingNumber);

        /// <summary>
        /// check the status of mobile payment request using processingNumber
        /// </summary>
        /// <remarks>
        /// processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        ApiResponse<PaymentMobileReponse> MobilestatusWithHttpInfo(List<string> processingNumber);
        /// <summary>
        /// Make an payment using orangemoney
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>PaymentMobileReponse</returns>
        PaymentMobileReponse Orangemoney(Orangemoney body);

        /// <summary>
        /// Make an payment using orangemoney
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        ApiResponse<PaymentMobileReponse> OrangemoneyWithHttpInfo(Orangemoney body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Make a new mobilemoney payment
        /// </summary>
        /// <remarks>
        /// Make an payment using MobileMoney
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        System.Threading.Tasks.Task<PaymentMobileReponse> MobilemoneyAsync(Orangemoney body);

        /// <summary>
        /// Make a new mobilemoney payment
        /// </summary>
        /// <remarks>
        /// Make an payment using MobileMoney
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> MobilemoneyAsyncWithHttpInfo(Orangemoney body);
        /// <summary>
        /// check the status of mobile payment request using processingNumber
        /// </summary>
        /// <remarks>
        /// processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        System.Threading.Tasks.Task<PaymentMobileReponse> MobilestatusAsync(List<string> processingNumber);

        /// <summary>
        /// check the status of mobile payment request using processingNumber
        /// </summary>
        /// <remarks>
        /// processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> MobilestatusAsyncWithHttpInfo(List<string> processingNumber);
        /// <summary>
        /// Make an payment using orangemoney
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        System.Threading.Tasks.Task<PaymentMobileReponse> OrangemoneyAsync(Orangemoney body);

        /// <summary>
        /// Make an payment using orangemoney
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> OrangemoneyAsyncWithHttpInfo(Orangemoney body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MobilePaymentApi : IMobilePaymentApi
    {
        private IO.SprintPay.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobilePaymentApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.SprintPay.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobilePaymentApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.SprintPay.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.SprintPay.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Make a new mobilemoney payment Make an payment using MobileMoney
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>PaymentMobileReponse</returns>
        public PaymentMobileReponse Mobilemoney(Orangemoney body)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = MobilemoneyWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Make a new mobilemoney payment Make an payment using MobileMoney
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        public ApiResponse<PaymentMobileReponse> MobilemoneyWithHttpInfo(Orangemoney body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobilePaymentApi->Mobilemoney");

            var localVarPath = "/payment/mobilemoney/request";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Mobilemoney", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

        /// <summary>
        /// Make a new mobilemoney payment Make an payment using MobileMoney
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        public async System.Threading.Tasks.Task<PaymentMobileReponse> MobilemoneyAsync(Orangemoney body)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = await MobilemoneyAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Make a new mobilemoney payment Make an payment using MobileMoney
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Mobilemoney object that needs to be added to the body of request</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> MobilemoneyAsyncWithHttpInfo(Orangemoney body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobilePaymentApi->Mobilemoney");

            var localVarPath = "/payment/mobilemoney/request";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Mobilemoney", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

        /// <summary>
        /// check the status of mobile payment request using processingNumber processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>PaymentMobileReponse</returns>
        public PaymentMobileReponse Mobilestatus(List<string> processingNumber)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = MobilestatusWithHttpInfo(processingNumber);
            return localVarResponse.Data;
        }

        /// <summary>
        /// check the status of mobile payment request using processingNumber processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        public ApiResponse<PaymentMobileReponse> MobilestatusWithHttpInfo(List<string> processingNumber)
        {
            // verify the required parameter 'processingNumber' is set
            if (processingNumber == null)
                throw new ApiException(400, "Missing required parameter 'processingNumber' when calling MobilePaymentApi->Mobilestatus");

            var localVarPath = "/payement/mobilemoney/check";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
                localVarHeaderParams.Add("Content-type", localVarHttpHeaderAccept);
            if (processingNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "processingNumber", processingNumber)); // query parameter

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Mobilestatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

        /// <summary>
        /// check the status of mobile payment request using processingNumber processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        public async System.Threading.Tasks.Task<PaymentMobileReponse> MobilestatusAsync(List<string> processingNumber)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = await MobilestatusAsyncWithHttpInfo(processingNumber);
            return localVarResponse.Data;

        }

        /// <summary>
        /// check the status of mobile payment request using processingNumber processingNumber returned by the previous endpoint(Alpha-numeric, space and some special characters)
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="processingNumber">status by processingNumber</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> MobilestatusAsyncWithHttpInfo(List<string> processingNumber)
        {
            // verify the required parameter 'processingNumber' is set
            if (processingNumber == null)
                throw new ApiException(400, "Missing required parameter 'processingNumber' when calling MobilePaymentApi->Mobilestatus");

            var localVarPath = "/payement/mobilemoney/check";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (processingNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "processingNumber", processingNumber)); // query parameter

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Mobilestatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

        /// <summary>
        /// Make an payment using orangemoney 
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>PaymentMobileReponse</returns>
        public PaymentMobileReponse Orangemoney(Orangemoney body)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = OrangemoneyWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Make an payment using orangemoney 
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>ApiResponse of PaymentMobileReponse</returns>
        public ApiResponse<PaymentMobileReponse> OrangemoneyWithHttpInfo(Orangemoney body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobilePaymentApi->Orangemoney");

            var localVarPath = "/payment/orangemoney/request";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Orangemoney", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

        /// <summary>
        /// Make an payment using orangemoney 
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>Task of PaymentMobileReponse</returns>
        public async System.Threading.Tasks.Task<PaymentMobileReponse> OrangemoneyAsync(Orangemoney body)
        {
            ApiResponse<PaymentMobileReponse> localVarResponse = await OrangemoneyAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Make an payment using orangemoney 
        /// </summary>
        /// <exception cref="IO.SprintPay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">object that needs to be added to the body of request</param>
        /// <returns>Task of ApiResponse (PaymentMobileReponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentMobileReponse>> OrangemoneyAsyncWithHttpInfo(Orangemoney body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MobilePaymentApi->Orangemoney");

            var localVarPath = "/payment/orangemoney/request";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Datetime) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Datetime")))
            {
                localVarHeaderParams["Datetime"] = Configuration.GetApiKeyWithPrefix("Datetime");
            }
            // authentication (autorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Orangemoney", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentMobileReponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaymentMobileReponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentMobileReponse)));
        }

    }
}