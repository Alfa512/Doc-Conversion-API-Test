using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWordApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        void WordConvert (string sourceFileName, string resultFileName, string format);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordConvertWithHttpInfo (string sourceFileName, string resultFileName, string format);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordConvertAsync (string sourceFileName, string resultFileName, string format);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordConvertAsyncWithHttpInfo (string sourceFileName, string resultFileName, string format);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        void WordConvertPost (string resultFileName, string format, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordConvertPostWithHttpInfo (string resultFileName, string format, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordConvertPostAsync (string resultFileName, string format, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordConvertPostAsyncWithHttpInfo (string resultFileName, string format, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns></returns>
        void WordJoin (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordJoinWithHttpInfo (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordJoinAsync (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordJoinAsyncWithHttpInfo (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns></returns>
        void WordJoinPost (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordJoinPostWithHttpInfo (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordJoinPostAsync (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordJoinPostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns></returns>
        void WordMailMerge (string sourceFileName, string resultFileName, string dataFilePath);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordMailMergeWithHttpInfo (string sourceFileName, string resultFileName, string dataFilePath);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordMailMergeAsync (string sourceFileName, string resultFileName, string dataFilePath);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordMailMergeAsyncWithHttpInfo (string sourceFileName, string resultFileName, string dataFilePath);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        void WordMailMergePost (string sourceFileName, string resultFileName, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordMailMergePostWithHttpInfo (string sourceFileName, string resultFileName, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordMailMergePostAsync (string sourceFileName, string resultFileName, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordMailMergePostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> WordGetDocumentProperties (string sourceFileName);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        ApiResponse<Dictionary<string, string>> WordGetDocumentPropertiesWithHttpInfo (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, string>> WordGetDocumentPropertiesAsync (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, string>>> WordGetDocumentPropertiesAsyncWithHttpInfo (string sourceFileName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        void WordSetDocumentProperties (string sourceFileName, string resultFileName, Properties properties);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordSetDocumentPropertiesWithHttpInfo (string sourceFileName, string resultFileName, Properties properties);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordSetDocumentPropertiesAsync (string sourceFileName, string resultFileName, Properties properties);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordSetDocumentPropertiesAsyncWithHttpInfo (string sourceFileName, string resultFileName, Properties properties);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>int?</returns>
        int? WordPageCount (string sourceFileName);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageCountWithHttpInfo (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageCountAsync (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageCountAsyncWithHttpInfo (string sourceFileName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>int?</returns>
        int? WordPageCountPost (Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageCountPostWithHttpInfo (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageCountPostAsync (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageCountPostAsyncWithHttpInfo (Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>int?</returns>
        int? WordPageParagraphCount (string sourceFileName, int? pageNumber);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageParagraphCountWithHttpInfo (string sourceFileName, int? pageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageParagraphCountAsync (string sourceFileName, int? pageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageParagraphCountAsyncWithHttpInfo (string sourceFileName, int? pageNumber);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>int?</returns>
        int? WordPageParagraphCountPost (int? pageNumber, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageParagraphCountPostWithHttpInfo (int? pageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageParagraphCountPostAsync (int? pageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageParagraphCountPostAsyncWithHttpInfo (int? pageNumber, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>int?</returns>
        int? WordPageWordCount (string sourceFileName, int? pageNumber);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageWordCountWithHttpInfo (string sourceFileName, int? pageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageWordCountAsync (string sourceFileName, int? pageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageWordCountAsyncWithHttpInfo (string sourceFileName, int? pageNumber);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>int?</returns>
        int? WordPageWordCountPost (int? pageNumber, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordPageWordCountPostWithHttpInfo (int? pageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordPageWordCountPostAsync (int? pageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordPageWordCountPostAsyncWithHttpInfo (int? pageNumber, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>int?</returns>
        int? WordParagraphCount (string sourceFileName);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordParagraphCountWithHttpInfo (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordParagraphCountAsync (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordParagraphCountAsyncWithHttpInfo (string sourceFileName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>int?</returns>
        int? WordParagraphCountPost (Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordParagraphCountPostWithHttpInfo (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordParagraphCountPostAsync (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordParagraphCountPostAsyncWithHttpInfo (Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>string</returns>
        string WordConvertToPDF (string sourceFileName, string resultFileName = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> WordConvertToPDFWithHttpInfo (string sourceFileName, string resultFileName = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> WordConvertToPDFAsync (string sourceFileName, string resultFileName = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> WordConvertToPDFAsyncWithHttpInfo (string sourceFileName, string resultFileName = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns></returns>
        void WordFindAndReplace (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordFindAndReplaceWithHttpInfo (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordFindAndReplaceAsync (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordFindAndReplaceAsyncWithHttpInfo (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns></returns>
        void WordFindAndReplacePost (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordFindAndReplacePostWithHttpInfo (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordFindAndReplacePostAsync (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordFindAndReplacePostAsyncWithHttpInfo (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>Stream</returns>
        Stream WordConvertToStream (string sourceFileName, string format);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> WordConvertToStreamWithHttpInfo (string sourceFileName, string format);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> WordConvertToStreamAsync (string sourceFileName, string format);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> WordConvertToStreamAsyncWithHttpInfo (string sourceFileName, string format);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Stream</returns>
        Stream WordConvertToStreamPost (string format, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> WordConvertToStreamPostWithHttpInfo (string format, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> WordConvertToStreamPostAsync (string format, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> WordConvertToStreamPostAsyncWithHttpInfo (string format, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns></returns>
        void WordSplit (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordSplitWithHttpInfo (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordSplitAsync (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordSplitAsyncWithHttpInfo (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        void WordSplitPost (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordSplitPostWithHttpInfo (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordSplitPostAsync (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordSplitPostAsyncWithHttpInfo (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> WordThumbnail (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> WordThumbnailWithHttpInfo (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> WordThumbnailAsync (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> WordThumbnailAsyncWithHttpInfo (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> WordThumbnailPost (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> WordThumbnailPostWithHttpInfo (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> WordThumbnailPostAsync (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> WordThumbnailPostAsyncWithHttpInfo (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns></returns>
        void WordTextWatermark (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordTextWatermarkWithHttpInfo (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordTextWatermarkAsync (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordTextWatermarkAsyncWithHttpInfo (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        void WordImageWatermarkPost (string sourceFileName, string resultFileName, Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> WordImageWatermarkPostWithHttpInfo (string sourceFileName, string resultFileName, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task WordImageWatermarkPostAsync (string sourceFileName, string resultFileName, Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> WordImageWatermarkPostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>int?</returns>
        int? WordWordCount (string sourceFileName);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordWordCountWithHttpInfo (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordWordCountAsync (string sourceFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordWordCountAsyncWithHttpInfo (string sourceFileName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>int?</returns>
        int? WordWordCountPost (Stream file);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> WordWordCountPostWithHttpInfo (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> WordWordCountPostAsync (Stream file);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> WordWordCountPostAsyncWithHttpInfo (Stream file);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WordApi : IWordApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WordApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WordApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WordApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="format"></param> 
        /// <returns></returns>
        public void WordConvert (string sourceFileName, string resultFileName, string format)
        {
             WordConvertWithHttpInfo(sourceFileName, resultFileName, format);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="format"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordConvertWithHttpInfo (string sourceFileName, string resultFileName, string format)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordConvert");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordConvert");
            
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling WordApi->WordConvert");
            
    
            var path_ = "/api/word/convert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvert: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordConvertAsync (string sourceFileName, string resultFileName, string format)
        {
             await WordConvertAsyncWithHttpInfo(sourceFileName, resultFileName, format);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordConvertAsyncWithHttpInfo (string sourceFileName, string resultFileName, string format)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordConvert");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordConvert");
            // verify the required parameter 'format' is set
            if (format == null) throw new ApiException(400, "Missing required parameter 'format' when calling WordConvert");
            
    
            var path_ = "/api/word/convert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvert: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="format"></param> 
        /// <param name="file"></param> 
        /// <returns></returns>
        public void WordConvertPost (string resultFileName, string format, Stream file)
        {
             WordConvertPostWithHttpInfo(resultFileName, format, file);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="format"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordConvertPostWithHttpInfo (string resultFileName, string format, Stream file)
        {
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordConvertPost");
            
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling WordApi->WordConvertPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordConvertPost");
            
    
            var path_ = "/api/word/convert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordConvertPostAsync (string resultFileName, string format, Stream file)
        {
             await WordConvertPostAsyncWithHttpInfo(resultFileName, format, file);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordConvertPostAsyncWithHttpInfo (string resultFileName, string format, Stream file)
        {
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordConvertPost");
            // verify the required parameter 'format' is set
            if (format == null) throw new ApiException(400, "Missing required parameter 'format' when calling WordConvertPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordConvertPost");
            
    
            var path_ = "/api/word/convert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="insertFileName"></param> 
        /// <param name="insertAfterPageNumber"></param> 
        /// <returns></returns>
        public void WordJoin (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null)
        {
             WordJoinWithHttpInfo(sourceFileName, resultFileName, insertFileName, insertAfterPageNumber);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="insertFileName"></param> 
        /// <param name="insertAfterPageNumber"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordJoinWithHttpInfo (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordJoin");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordJoin");
            
            // verify the required parameter 'insertFileName' is set
            if (insertFileName == null)
                throw new ApiException(400, "Missing required parameter 'insertFileName' when calling WordApi->WordJoin");
            
    
            var path_ = "/api/word/join";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (insertFileName != null) queryParams.Add("insertFileName", Configuration.ApiClient.ParameterToString(insertFileName)); // query parameter
            if (insertAfterPageNumber != null) queryParams.Add("insertAfterPageNumber", Configuration.ApiClient.ParameterToString(insertAfterPageNumber)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordJoin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordJoin: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordJoinAsync (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null)
        {
             await WordJoinAsyncWithHttpInfo(sourceFileName, resultFileName, insertFileName, insertAfterPageNumber);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="insertFileName"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordJoinAsyncWithHttpInfo (string sourceFileName, string resultFileName, string insertFileName, int? insertAfterPageNumber = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordJoin");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordJoin");
            // verify the required parameter 'insertFileName' is set
            if (insertFileName == null) throw new ApiException(400, "Missing required parameter 'insertFileName' when calling WordJoin");
            
    
            var path_ = "/api/word/join";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (insertFileName != null) queryParams.Add("insertFileName", Configuration.ApiClient.ParameterToString(insertFileName)); // query parameter
            if (insertAfterPageNumber != null) queryParams.Add("insertAfterPageNumber", Configuration.ApiClient.ParameterToString(insertAfterPageNumber)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordJoin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordJoin: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <param name="insertAfterPageNumber"></param> 
        /// <returns></returns>
        public void WordJoinPost (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null)
        {
             WordJoinPostWithHttpInfo(sourceFileName, resultFileName, file, insertAfterPageNumber);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <param name="insertAfterPageNumber"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordJoinPostWithHttpInfo (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordJoinPost");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordJoinPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordJoinPost");
            
    
            var path_ = "/api/word/join";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (insertAfterPageNumber != null) queryParams.Add("insertAfterPageNumber", Configuration.ApiClient.ParameterToString(insertAfterPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordJoinPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordJoinPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordJoinPostAsync (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null)
        {
             await WordJoinPostAsyncWithHttpInfo(sourceFileName, resultFileName, file, insertAfterPageNumber);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <param name="insertAfterPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordJoinPostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file, int? insertAfterPageNumber = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordJoinPost");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordJoinPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordJoinPost");
            
    
            var path_ = "/api/word/join";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (insertAfterPageNumber != null) queryParams.Add("insertAfterPageNumber", Configuration.ApiClient.ParameterToString(insertAfterPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordJoinPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordJoinPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="dataFilePath"></param> 
        /// <returns></returns>
        public void WordMailMerge (string sourceFileName, string resultFileName, string dataFilePath)
        {
             WordMailMergeWithHttpInfo(sourceFileName, resultFileName, dataFilePath);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="dataFilePath"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordMailMergeWithHttpInfo (string sourceFileName, string resultFileName, string dataFilePath)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordMailMerge");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordMailMerge");
            
            // verify the required parameter 'dataFilePath' is set
            if (dataFilePath == null)
                throw new ApiException(400, "Missing required parameter 'dataFilePath' when calling WordApi->WordMailMerge");
            
    
            var path_ = "/api/word/mailmerge";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (dataFilePath != null) queryParams.Add("dataFilePath", Configuration.ApiClient.ParameterToString(dataFilePath)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordMailMerge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordMailMerge: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordMailMergeAsync (string sourceFileName, string resultFileName, string dataFilePath)
        {
             await WordMailMergeAsyncWithHttpInfo(sourceFileName, resultFileName, dataFilePath);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="dataFilePath"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordMailMergeAsyncWithHttpInfo (string sourceFileName, string resultFileName, string dataFilePath)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordMailMerge");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordMailMerge");
            // verify the required parameter 'dataFilePath' is set
            if (dataFilePath == null) throw new ApiException(400, "Missing required parameter 'dataFilePath' when calling WordMailMerge");
            
    
            var path_ = "/api/word/mailmerge";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (dataFilePath != null) queryParams.Add("dataFilePath", Configuration.ApiClient.ParameterToString(dataFilePath)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordMailMerge: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordMailMerge: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <returns></returns>
        public void WordMailMergePost (string sourceFileName, string resultFileName, Stream file)
        {
             WordMailMergePostWithHttpInfo(sourceFileName, resultFileName, file);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordMailMergePostWithHttpInfo (string sourceFileName, string resultFileName, Stream file)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordMailMergePost");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordMailMergePost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordMailMergePost");
            
    
            var path_ = "/api/word/mailmerge";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordMailMergePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordMailMergePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordMailMergePostAsync (string sourceFileName, string resultFileName, Stream file)
        {
             await WordMailMergePostAsyncWithHttpInfo(sourceFileName, resultFileName, file);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordMailMergePostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordMailMergePost");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordMailMergePost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordMailMergePost");
            
    
            var path_ = "/api/word/mailmerge";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordMailMergePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordMailMergePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> WordGetDocumentProperties (string sourceFileName)
        {
             ApiResponse<Dictionary<string, string>> response = WordGetDocumentPropertiesWithHttpInfo(sourceFileName);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        public ApiResponse< Dictionary<string, string> > WordGetDocumentPropertiesWithHttpInfo (string sourceFileName)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordGetDocumentProperties");
            
    
            var path_ = "/api/word/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordGetDocumentProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordGetDocumentProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Dictionary<string, string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, string>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, string>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, string>> WordGetDocumentPropertiesAsync (string sourceFileName)
        {
             ApiResponse<Dictionary<string, string>> response = await WordGetDocumentPropertiesAsyncWithHttpInfo(sourceFileName);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, string>>> WordGetDocumentPropertiesAsyncWithHttpInfo (string sourceFileName)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordGetDocumentProperties");
            
    
            var path_ = "/api/word/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordGetDocumentProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordGetDocumentProperties: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Dictionary<string, string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Dictionary<string, string>) Configuration.ApiClient.Deserialize(response, typeof(Dictionary<string, string>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="properties"></param> 
        /// <returns></returns>
        public void WordSetDocumentProperties (string sourceFileName, string resultFileName, Properties properties)
        {
             WordSetDocumentPropertiesWithHttpInfo(sourceFileName, resultFileName, properties);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="properties"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordSetDocumentPropertiesWithHttpInfo (string sourceFileName, string resultFileName, Properties properties)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordSetDocumentProperties");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordSetDocumentProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null)
                throw new ApiException(400, "Missing required parameter 'properties' when calling WordApi->WordSetDocumentProperties");
            
    
            var path_ = "/api/word/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            
            if (properties.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            }
            else
            {
                postBody = properties; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSetDocumentProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSetDocumentProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordSetDocumentPropertiesAsync (string sourceFileName, string resultFileName, Properties properties)
        {
             await WordSetDocumentPropertiesAsyncWithHttpInfo(sourceFileName, resultFileName, properties);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="properties"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordSetDocumentPropertiesAsyncWithHttpInfo (string sourceFileName, string resultFileName, Properties properties)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordSetDocumentProperties");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordSetDocumentProperties");
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling WordSetDocumentProperties");
            
    
            var path_ = "/api/word/metadata";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(properties); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSetDocumentProperties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSetDocumentProperties: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>int?</returns>
        public int? WordPageCount (string sourceFileName)
        {
             ApiResponse<int?> response = WordPageCountWithHttpInfo(sourceFileName);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageCountWithHttpInfo (string sourceFileName)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordPageCount");
            
    
            var path_ = "/api/word/pagecount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageCountAsync (string sourceFileName)
        {
             ApiResponse<int?> response = await WordPageCountAsyncWithHttpInfo(sourceFileName);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageCountAsyncWithHttpInfo (string sourceFileName)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordPageCount");
            
    
            var path_ = "/api/word/pagecount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageCount: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>int?</returns>
        public int? WordPageCountPost (Stream file)
        {
             ApiResponse<int?> response = WordPageCountPostWithHttpInfo(file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageCountPostWithHttpInfo (Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordPageCountPost");
            
    
            var path_ = "/api/word/pagecount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageCountPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageCountPostAsync (Stream file)
        {
             ApiResponse<int?> response = await WordPageCountPostAsyncWithHttpInfo(file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageCountPostAsyncWithHttpInfo (Stream file)
        {
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordPageCountPost");
            
    
            var path_ = "/api/word/pagecount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageCountPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>int?</returns>
        public int? WordPageParagraphCount (string sourceFileName, int? pageNumber)
        {
             ApiResponse<int?> response = WordPageParagraphCountWithHttpInfo(sourceFileName, pageNumber);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageParagraphCountWithHttpInfo (string sourceFileName, int? pageNumber)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordPageParagraphCount");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordApi->WordPageParagraphCount");
            
    
            var path_ = "/api/word/pageparagraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageParagraphCountAsync (string sourceFileName, int? pageNumber)
        {
             ApiResponse<int?> response = await WordPageParagraphCountAsyncWithHttpInfo(sourceFileName, pageNumber);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageParagraphCountAsyncWithHttpInfo (string sourceFileName, int? pageNumber)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordPageParagraphCount");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordPageParagraphCount");
            
    
            var path_ = "/api/word/pageparagraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCount: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns>int?</returns>
        public int? WordPageParagraphCountPost (int? pageNumber, Stream file)
        {
             ApiResponse<int?> response = WordPageParagraphCountPostWithHttpInfo(pageNumber, file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageParagraphCountPostWithHttpInfo (int? pageNumber, Stream file)
        {
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordApi->WordPageParagraphCountPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordPageParagraphCountPost");
            
    
            var path_ = "/api/word/pageparagraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCountPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageParagraphCountPostAsync (int? pageNumber, Stream file)
        {
             ApiResponse<int?> response = await WordPageParagraphCountPostAsyncWithHttpInfo(pageNumber, file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageParagraphCountPostAsyncWithHttpInfo (int? pageNumber, Stream file)
        {
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordPageParagraphCountPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordPageParagraphCountPost");
            
    
            var path_ = "/api/word/pageparagraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageParagraphCountPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>int?</returns>
        public int? WordPageWordCount (string sourceFileName, int? pageNumber)
        {
             ApiResponse<int?> response = WordPageWordCountWithHttpInfo(sourceFileName, pageNumber);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageWordCountWithHttpInfo (string sourceFileName, int? pageNumber)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordPageWordCount");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordApi->WordPageWordCount");
            
    
            var path_ = "/api/word/pagewordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageWordCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageWordCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageWordCountAsync (string sourceFileName, int? pageNumber)
        {
             ApiResponse<int?> response = await WordPageWordCountAsyncWithHttpInfo(sourceFileName, pageNumber);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageWordCountAsyncWithHttpInfo (string sourceFileName, int? pageNumber)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordPageWordCount");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordPageWordCount");
            
    
            var path_ = "/api/word/pagewordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageWordCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageWordCount: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns>int?</returns>
        public int? WordPageWordCountPost (int? pageNumber, Stream file)
        {
             ApiResponse<int?> response = WordPageWordCountPostWithHttpInfo(pageNumber, file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordPageWordCountPostWithHttpInfo (int? pageNumber, Stream file)
        {
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordApi->WordPageWordCountPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordPageWordCountPost");
            
    
            var path_ = "/api/word/pagewordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageWordCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageWordCountPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordPageWordCountPostAsync (int? pageNumber, Stream file)
        {
             ApiResponse<int?> response = await WordPageWordCountPostAsyncWithHttpInfo(pageNumber, file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordPageWordCountPostAsyncWithHttpInfo (int? pageNumber, Stream file)
        {
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling WordPageWordCountPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordPageWordCountPost");
            
    
            var path_ = "/api/word/pagewordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordPageWordCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordPageWordCountPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>int?</returns>
        public int? WordParagraphCount (string sourceFileName)
        {
             ApiResponse<int?> response = WordParagraphCountWithHttpInfo(sourceFileName);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordParagraphCountWithHttpInfo (string sourceFileName)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordParagraphCount");
            
    
            var path_ = "/api/word/paragraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordParagraphCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordParagraphCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordParagraphCountAsync (string sourceFileName)
        {
             ApiResponse<int?> response = await WordParagraphCountAsyncWithHttpInfo(sourceFileName);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordParagraphCountAsyncWithHttpInfo (string sourceFileName)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordParagraphCount");
            
    
            var path_ = "/api/word/paragraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordParagraphCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordParagraphCount: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>int?</returns>
        public int? WordParagraphCountPost (Stream file)
        {
             ApiResponse<int?> response = WordParagraphCountPostWithHttpInfo(file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordParagraphCountPostWithHttpInfo (Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordParagraphCountPost");
            
    
            var path_ = "/api/word/paragraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordParagraphCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordParagraphCountPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordParagraphCountPostAsync (Stream file)
        {
             ApiResponse<int?> response = await WordParagraphCountPostAsyncWithHttpInfo(file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordParagraphCountPostAsyncWithHttpInfo (Stream file)
        {
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordParagraphCountPost");
            
    
            var path_ = "/api/word/paragraphcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordParagraphCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordParagraphCountPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <returns>string</returns>
        public string WordConvertToPDF (string sourceFileName, string resultFileName = null)
        {
             ApiResponse<string> response = WordConvertToPDFWithHttpInfo(sourceFileName, resultFileName);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > WordConvertToPDFWithHttpInfo (string sourceFileName, string resultFileName = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordConvertToPDF");
            
    
            var path_ = "/api/word/pdfviewer";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToPDF: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToPDF: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> WordConvertToPDFAsync (string sourceFileName, string resultFileName = null)
        {
             ApiResponse<string> response = await WordConvertToPDFAsyncWithHttpInfo(sourceFileName, resultFileName);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> WordConvertToPDFAsyncWithHttpInfo (string sourceFileName, string resultFileName = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordConvertToPDF");
            
    
            var path_ = "/api/word/pdfviewer";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToPDF: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToPDF: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="searchIteams"></param> 
        /// <param name="replaceItems"></param> 
        /// <param name="matchCase"></param> 
        /// <param name="matchWholeWord"></param> 
        /// <param name="matchWildCards"></param> 
        /// <returns></returns>
        public void WordFindAndReplace (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
             WordFindAndReplaceWithHttpInfo(sourceFileName, resultFileName, searchIteams, replaceItems, matchCase, matchWholeWord, matchWildCards);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="searchIteams"></param> 
        /// <param name="replaceItems"></param> 
        /// <param name="matchCase"></param> 
        /// <param name="matchWholeWord"></param> 
        /// <param name="matchWildCards"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordFindAndReplaceWithHttpInfo (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordFindAndReplace");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordFindAndReplace");
            
            // verify the required parameter 'searchIteams' is set
            if (searchIteams == null)
                throw new ApiException(400, "Missing required parameter 'searchIteams' when calling WordApi->WordFindAndReplace");
            
            // verify the required parameter 'replaceItems' is set
            if (replaceItems == null)
                throw new ApiException(400, "Missing required parameter 'replaceItems' when calling WordApi->WordFindAndReplace");
            
    
            var path_ = "/api/word/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (searchIteams != null) queryParams.Add("searchIteams", Configuration.ApiClient.ParameterToString(searchIteams)); // query parameter
            if (replaceItems != null) queryParams.Add("replaceItems", Configuration.ApiClient.ParameterToString(replaceItems)); // query parameter
            if (matchCase != null) queryParams.Add("matchCase", Configuration.ApiClient.ParameterToString(matchCase)); // query parameter
            if (matchWholeWord != null) queryParams.Add("matchWholeWord", Configuration.ApiClient.ParameterToString(matchWholeWord)); // query parameter
            if (matchWildCards != null) queryParams.Add("matchWildCards", Configuration.ApiClient.ParameterToString(matchWildCards)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordFindAndReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordFindAndReplace: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordFindAndReplaceAsync (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
             await WordFindAndReplaceAsyncWithHttpInfo(sourceFileName, resultFileName, searchIteams, replaceItems, matchCase, matchWholeWord, matchWildCards);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordFindAndReplaceAsyncWithHttpInfo (string sourceFileName, string resultFileName, List<string> searchIteams, List<string> replaceItems, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordFindAndReplace");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordFindAndReplace");
            // verify the required parameter 'searchIteams' is set
            if (searchIteams == null) throw new ApiException(400, "Missing required parameter 'searchIteams' when calling WordFindAndReplace");
            // verify the required parameter 'replaceItems' is set
            if (replaceItems == null) throw new ApiException(400, "Missing required parameter 'replaceItems' when calling WordFindAndReplace");
            
    
            var path_ = "/api/word/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (searchIteams != null) queryParams.Add("searchIteams", Configuration.ApiClient.ParameterToString(searchIteams)); // query parameter
            if (replaceItems != null) queryParams.Add("replaceItems", Configuration.ApiClient.ParameterToString(replaceItems)); // query parameter
            if (matchCase != null) queryParams.Add("matchCase", Configuration.ApiClient.ParameterToString(matchCase)); // query parameter
            if (matchWholeWord != null) queryParams.Add("matchWholeWord", Configuration.ApiClient.ParameterToString(matchWholeWord)); // query parameter
            if (matchWildCards != null) queryParams.Add("matchWildCards", Configuration.ApiClient.ParameterToString(matchWildCards)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordFindAndReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordFindAndReplace: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="searchIteams"></param> 
        /// <param name="replaceItems"></param> 
        /// <param name="file"></param> 
        /// <param name="matchCase"></param> 
        /// <param name="matchWholeWord"></param> 
        /// <param name="matchWildCards"></param> 
        /// <returns></returns>
        public void WordFindAndReplacePost (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
             WordFindAndReplacePostWithHttpInfo(resultFileName, searchIteams, replaceItems, file, matchCase, matchWholeWord, matchWildCards);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="searchIteams"></param> 
        /// <param name="replaceItems"></param> 
        /// <param name="file"></param> 
        /// <param name="matchCase"></param> 
        /// <param name="matchWholeWord"></param> 
        /// <param name="matchWildCards"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordFindAndReplacePostWithHttpInfo (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordFindAndReplacePost");
            
            // verify the required parameter 'searchIteams' is set
            if (searchIteams == null)
                throw new ApiException(400, "Missing required parameter 'searchIteams' when calling WordApi->WordFindAndReplacePost");
            
            // verify the required parameter 'replaceItems' is set
            if (replaceItems == null)
                throw new ApiException(400, "Missing required parameter 'replaceItems' when calling WordApi->WordFindAndReplacePost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordFindAndReplacePost");
            
    
            var path_ = "/api/word/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (searchIteams != null) queryParams.Add("searchIteams", Configuration.ApiClient.ParameterToString(searchIteams)); // query parameter
            if (replaceItems != null) queryParams.Add("replaceItems", Configuration.ApiClient.ParameterToString(replaceItems)); // query parameter
            if (matchCase != null) queryParams.Add("matchCase", Configuration.ApiClient.ParameterToString(matchCase)); // query parameter
            if (matchWholeWord != null) queryParams.Add("matchWholeWord", Configuration.ApiClient.ParameterToString(matchWholeWord)); // query parameter
            if (matchWildCards != null) queryParams.Add("matchWildCards", Configuration.ApiClient.ParameterToString(matchWildCards)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordFindAndReplacePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordFindAndReplacePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordFindAndReplacePostAsync (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
             await WordFindAndReplacePostAsyncWithHttpInfo(resultFileName, searchIteams, replaceItems, file, matchCase, matchWholeWord, matchWildCards);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="searchIteams"></param>
        /// <param name="replaceItems"></param>
        /// <param name="file"></param>
        /// <param name="matchCase"></param>
        /// <param name="matchWholeWord"></param>
        /// <param name="matchWildCards"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordFindAndReplacePostAsyncWithHttpInfo (string resultFileName, List<string> searchIteams, List<string> replaceItems, Stream file, bool? matchCase = null, bool? matchWholeWord = null, bool? matchWildCards = null)
        {
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordFindAndReplacePost");
            // verify the required parameter 'searchIteams' is set
            if (searchIteams == null) throw new ApiException(400, "Missing required parameter 'searchIteams' when calling WordFindAndReplacePost");
            // verify the required parameter 'replaceItems' is set
            if (replaceItems == null) throw new ApiException(400, "Missing required parameter 'replaceItems' when calling WordFindAndReplacePost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordFindAndReplacePost");
            
    
            var path_ = "/api/word/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (searchIteams != null) queryParams.Add("searchIteams", Configuration.ApiClient.ParameterToString(searchIteams)); // query parameter
            if (replaceItems != null) queryParams.Add("replaceItems", Configuration.ApiClient.ParameterToString(replaceItems)); // query parameter
            if (matchCase != null) queryParams.Add("matchCase", Configuration.ApiClient.ParameterToString(matchCase)); // query parameter
            if (matchWholeWord != null) queryParams.Add("matchWholeWord", Configuration.ApiClient.ParameterToString(matchWholeWord)); // query parameter
            if (matchWildCards != null) queryParams.Add("matchWildCards", Configuration.ApiClient.ParameterToString(matchWildCards)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordFindAndReplacePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordFindAndReplacePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="format"></param> 
        /// <returns>Stream</returns>
        public Stream WordConvertToStream (string sourceFileName, string format)
        {
             ApiResponse<Stream> response = WordConvertToStreamWithHttpInfo(sourceFileName, format);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="format"></param> 
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > WordConvertToStreamWithHttpInfo (string sourceFileName, string format)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordConvertToStream");
            
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling WordApi->WordConvertToStream");
            
    
            var path_ = "/api/word/sconvert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToStream: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToStream: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> WordConvertToStreamAsync (string sourceFileName, string format)
        {
             ApiResponse<Stream> response = await WordConvertToStreamAsyncWithHttpInfo(sourceFileName, format);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="format"></param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> WordConvertToStreamAsyncWithHttpInfo (string sourceFileName, string format)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordConvertToStream");
            // verify the required parameter 'format' is set
            if (format == null) throw new ApiException(400, "Missing required parameter 'format' when calling WordConvertToStream");
            
    
            var path_ = "/api/word/sconvert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToStream: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToStream: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="format"></param> 
        /// <param name="file"></param> 
        /// <returns>Stream</returns>
        public Stream WordConvertToStreamPost (string format, Stream file)
        {
             ApiResponse<Stream> response = WordConvertToStreamPostWithHttpInfo(format, file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="format"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > WordConvertToStreamPostWithHttpInfo (string format, Stream file)
        {
            
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling WordApi->WordConvertToStreamPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordConvertToStreamPost");
            
    
            var path_ = "/api/word/sconvert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToStreamPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToStreamPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> WordConvertToStreamPostAsync (string format, Stream file)
        {
             ApiResponse<Stream> response = await WordConvertToStreamPostAsyncWithHttpInfo(format, file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="format"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> WordConvertToStreamPostAsyncWithHttpInfo (string format, Stream file)
        {
            // verify the required parameter 'format' is set
            if (format == null) throw new ApiException(400, "Missing required parameter 'format' when calling WordConvertToStreamPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordConvertToStreamPost");
            
    
            var path_ = "/api/word/sconvert";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (format != null) queryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordConvertToStreamPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordConvertToStreamPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns></returns>
        public void WordSplit (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber)
        {
             WordSplitWithHttpInfo(sourceFileName, resultFileName, startPageNumber, endPageNumber);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordSplitWithHttpInfo (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordSplit");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordSplit");
            
            // verify the required parameter 'startPageNumber' is set
            if (startPageNumber == null)
                throw new ApiException(400, "Missing required parameter 'startPageNumber' when calling WordApi->WordSplit");
            
            // verify the required parameter 'endPageNumber' is set
            if (endPageNumber == null)
                throw new ApiException(400, "Missing required parameter 'endPageNumber' when calling WordApi->WordSplit");
            
    
            var path_ = "/api/word/split";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSplit: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSplit: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordSplitAsync (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber)
        {
             await WordSplitAsyncWithHttpInfo(sourceFileName, resultFileName, startPageNumber, endPageNumber);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordSplitAsyncWithHttpInfo (string sourceFileName, string resultFileName, int? startPageNumber, int? endPageNumber)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordSplit");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordSplit");
            // verify the required parameter 'startPageNumber' is set
            if (startPageNumber == null) throw new ApiException(400, "Missing required parameter 'startPageNumber' when calling WordSplit");
            // verify the required parameter 'endPageNumber' is set
            if (endPageNumber == null) throw new ApiException(400, "Missing required parameter 'endPageNumber' when calling WordSplit");
            
    
            var path_ = "/api/word/split";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSplit: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSplit: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns></returns>
        public void WordSplitPost (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file)
        {
             WordSplitPostWithHttpInfo(resultFileName, startPageNumber, endPageNumber, file);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordSplitPostWithHttpInfo (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file)
        {
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordSplitPost");
            
            // verify the required parameter 'startPageNumber' is set
            if (startPageNumber == null)
                throw new ApiException(400, "Missing required parameter 'startPageNumber' when calling WordApi->WordSplitPost");
            
            // verify the required parameter 'endPageNumber' is set
            if (endPageNumber == null)
                throw new ApiException(400, "Missing required parameter 'endPageNumber' when calling WordApi->WordSplitPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordSplitPost");
            
    
            var path_ = "/api/word/split";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSplitPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSplitPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordSplitPostAsync (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file)
        {
             await WordSplitPostAsyncWithHttpInfo(resultFileName, startPageNumber, endPageNumber, file);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="resultFileName"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordSplitPostAsyncWithHttpInfo (string resultFileName, int? startPageNumber, int? endPageNumber, Stream file)
        {
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordSplitPost");
            // verify the required parameter 'startPageNumber' is set
            if (startPageNumber == null) throw new ApiException(400, "Missing required parameter 'startPageNumber' when calling WordSplitPost");
            // verify the required parameter 'endPageNumber' is set
            if (endPageNumber == null) throw new ApiException(400, "Missing required parameter 'endPageNumber' when calling WordSplitPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordSplitPost");
            
    
            var path_ = "/api/word/split";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordSplitPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordSplitPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="thumbnailWidth"></param> 
        /// <param name="thumbnailHeight"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> WordThumbnail (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
             ApiResponse<List<string>> response = WordThumbnailWithHttpInfo(sourceFileName, thumbnailWidth, thumbnailHeight, startPageNumber, endPageNumber);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="thumbnailWidth"></param> 
        /// <param name="thumbnailHeight"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > WordThumbnailWithHttpInfo (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordThumbnail");
            
    
            var path_ = "/api/word/thumbnail";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (thumbnailWidth != null) queryParams.Add("thumbnailWidth", Configuration.ApiClient.ParameterToString(thumbnailWidth)); // query parameter
            if (thumbnailHeight != null) queryParams.Add("thumbnailHeight", Configuration.ApiClient.ParameterToString(thumbnailHeight)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordThumbnail: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordThumbnail: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> WordThumbnailAsync (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
             ApiResponse<List<string>> response = await WordThumbnailAsyncWithHttpInfo(sourceFileName, thumbnailWidth, thumbnailHeight, startPageNumber, endPageNumber);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> WordThumbnailAsyncWithHttpInfo (string sourceFileName, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordThumbnail");
            
    
            var path_ = "/api/word/thumbnail";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (thumbnailWidth != null) queryParams.Add("thumbnailWidth", Configuration.ApiClient.ParameterToString(thumbnailWidth)); // query parameter
            if (thumbnailHeight != null) queryParams.Add("thumbnailHeight", Configuration.ApiClient.ParameterToString(thumbnailHeight)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordThumbnail: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordThumbnail: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <param name="thumbnailWidth"></param> 
        /// <param name="thumbnailHeight"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> WordThumbnailPost (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
             ApiResponse<List<string>> response = WordThumbnailPostWithHttpInfo(file, thumbnailWidth, thumbnailHeight, startPageNumber, endPageNumber);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <param name="thumbnailWidth"></param> 
        /// <param name="thumbnailHeight"></param> 
        /// <param name="startPageNumber"></param> 
        /// <param name="endPageNumber"></param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > WordThumbnailPostWithHttpInfo (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordThumbnailPost");
            
    
            var path_ = "/api/word/thumbnail";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (thumbnailWidth != null) queryParams.Add("thumbnailWidth", Configuration.ApiClient.ParameterToString(thumbnailWidth)); // query parameter
            if (thumbnailHeight != null) queryParams.Add("thumbnailHeight", Configuration.ApiClient.ParameterToString(thumbnailHeight)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordThumbnailPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordThumbnailPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> WordThumbnailPostAsync (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
             ApiResponse<List<string>> response = await WordThumbnailPostAsyncWithHttpInfo(file, thumbnailWidth, thumbnailHeight, startPageNumber, endPageNumber);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <param name="thumbnailWidth"></param>
        /// <param name="thumbnailHeight"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> WordThumbnailPostAsyncWithHttpInfo (Stream file, int? thumbnailWidth = null, int? thumbnailHeight = null, int? startPageNumber = null, int? endPageNumber = null)
        {
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordThumbnailPost");
            
    
            var path_ = "/api/word/thumbnail";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (thumbnailWidth != null) queryParams.Add("thumbnailWidth", Configuration.ApiClient.ParameterToString(thumbnailWidth)); // query parameter
            if (thumbnailHeight != null) queryParams.Add("thumbnailHeight", Configuration.ApiClient.ParameterToString(thumbnailHeight)); // query parameter
            if (startPageNumber != null) queryParams.Add("startPageNumber", Configuration.ApiClient.ParameterToString(startPageNumber)); // query parameter
            if (endPageNumber != null) queryParams.Add("endPageNumber", Configuration.ApiClient.ParameterToString(endPageNumber)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordThumbnailPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordThumbnailPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="watermarkText"></param> 
        /// <param name="watermarkFont"></param> 
        /// <param name="watermarkFontSize"></param> 
        /// <returns></returns>
        public void WordTextWatermark (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null)
        {
             WordTextWatermarkWithHttpInfo(sourceFileName, resultFileName, watermarkText, watermarkFont, watermarkFontSize);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="watermarkText"></param> 
        /// <param name="watermarkFont"></param> 
        /// <param name="watermarkFontSize"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordTextWatermarkWithHttpInfo (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordTextWatermark");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordTextWatermark");
            
            // verify the required parameter 'watermarkText' is set
            if (watermarkText == null)
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling WordApi->WordTextWatermark");
            
    
            var path_ = "/api/word/watermark";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (watermarkText != null) queryParams.Add("watermarkText", Configuration.ApiClient.ParameterToString(watermarkText)); // query parameter
            if (watermarkFont != null) queryParams.Add("watermarkFont", Configuration.ApiClient.ParameterToString(watermarkFont)); // query parameter
            if (watermarkFontSize != null) queryParams.Add("watermarkFontSize", Configuration.ApiClient.ParameterToString(watermarkFontSize)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordTextWatermark: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordTextWatermark: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordTextWatermarkAsync (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null)
        {
             await WordTextWatermarkAsyncWithHttpInfo(sourceFileName, resultFileName, watermarkText, watermarkFont, watermarkFontSize);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="watermarkText"></param>
        /// <param name="watermarkFont"></param>
        /// <param name="watermarkFontSize"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordTextWatermarkAsyncWithHttpInfo (string sourceFileName, string resultFileName, string watermarkText, string watermarkFont = null, int? watermarkFontSize = null)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordTextWatermark");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordTextWatermark");
            // verify the required parameter 'watermarkText' is set
            if (watermarkText == null) throw new ApiException(400, "Missing required parameter 'watermarkText' when calling WordTextWatermark");
            
    
            var path_ = "/api/word/watermark";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            if (watermarkText != null) queryParams.Add("watermarkText", Configuration.ApiClient.ParameterToString(watermarkText)); // query parameter
            if (watermarkFont != null) queryParams.Add("watermarkFont", Configuration.ApiClient.ParameterToString(watermarkFont)); // query parameter
            if (watermarkFontSize != null) queryParams.Add("watermarkFontSize", Configuration.ApiClient.ParameterToString(watermarkFontSize)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordTextWatermark: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordTextWatermark: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <returns></returns>
        public void WordImageWatermarkPost (string sourceFileName, string resultFileName, Stream file)
        {
             WordImageWatermarkPostWithHttpInfo(sourceFileName, resultFileName, file);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <param name="resultFileName"></param> 
        /// <param name="file"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> WordImageWatermarkPostWithHttpInfo (string sourceFileName, string resultFileName, Stream file)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordImageWatermarkPost");
            
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null)
                throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordApi->WordImageWatermarkPost");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordImageWatermarkPost");
            
    
            var path_ = "/api/word/watermark";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordImageWatermarkPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordImageWatermarkPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task WordImageWatermarkPostAsync (string sourceFileName, string resultFileName, Stream file)
        {
             await WordImageWatermarkPostAsyncWithHttpInfo(sourceFileName, resultFileName, file);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <param name="resultFileName"></param>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> WordImageWatermarkPostAsyncWithHttpInfo (string sourceFileName, string resultFileName, Stream file)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordImageWatermarkPost");
            // verify the required parameter 'resultFileName' is set
            if (resultFileName == null) throw new ApiException(400, "Missing required parameter 'resultFileName' when calling WordImageWatermarkPost");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordImageWatermarkPost");
            
    
            var path_ = "/api/word/watermark";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            if (resultFileName != null) queryParams.Add("resultFileName", Configuration.ApiClient.ParameterToString(resultFileName)); // query parameter
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordImageWatermarkPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordImageWatermarkPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>int?</returns>
        public int? WordWordCount (string sourceFileName)
        {
             ApiResponse<int?> response = WordWordCountWithHttpInfo(sourceFileName);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordWordCountWithHttpInfo (string sourceFileName)
        {
            
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null)
                throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordApi->WordWordCount");
            
    
            var path_ = "/api/word/wordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordWordCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordWordCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordWordCountAsync (string sourceFileName)
        {
             ApiResponse<int?> response = await WordWordCountAsyncWithHttpInfo(sourceFileName);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="sourceFileName"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordWordCountAsyncWithHttpInfo (string sourceFileName)
        {
            // verify the required parameter 'sourceFileName' is set
            if (sourceFileName == null) throw new ApiException(400, "Missing required parameter 'sourceFileName' when calling WordWordCount");
            
    
            var path_ = "/api/word/wordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (sourceFileName != null) queryParams.Add("sourceFileName", Configuration.ApiClient.ParameterToString(sourceFileName)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordWordCount: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordWordCount: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>int?</returns>
        public int? WordWordCountPost (Stream file)
        {
             ApiResponse<int?> response = WordWordCountPostWithHttpInfo(file);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > WordWordCountPostWithHttpInfo (Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling WordApi->WordWordCountPost");
            
    
            var path_ = "/api/word/wordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordWordCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordWordCountPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> WordWordCountPostAsync (Stream file)
        {
             ApiResponse<int?> response = await WordWordCountPostAsyncWithHttpInfo(file);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> WordWordCountPostAsyncWithHttpInfo (Stream file)
        {
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling WordWordCountPost");
            
    
            var path_ = "/api/word/wordcount";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/form-data"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling WordWordCountPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling WordWordCountPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<int?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(response, typeof(int?)));
            
        }
        
    }
    
}
