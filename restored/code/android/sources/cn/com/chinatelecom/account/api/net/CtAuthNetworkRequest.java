package cn.com.chinatelecom.account.api.net;

import android.content.Context;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.encrypt.Xor;
import cn.com.chinatelecom.account.api.utils.ApiUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.LogUtils;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import cn.com.chinatelecom.account.api.utils.ResultUtils;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.SocketTimeoutException;
import java.net.UnknownHostException;
import javax.net.ssl.HttpsURLConnection;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public final class CtAuthNetworkRequest extends NetworkRequest {
    private static final String TAG = "CtAuthNetworkRequest";

    public CtAuthNetworkRequest(Context context) {
        super(context);
    }

    @Override // cn.com.chinatelecom.account.api.net.INet
    public ResponseInfo sendRequest(String str, String str2, int i, RequestConfig requestConfig, boolean z) {
        if (isHttps(str)) {
            return sendHttpsRequest(str, str2, i, requestConfig, z);
        }
        return sendHttpRequest(str, str2, i, requestConfig);
    }

    /* JADX WARN: Code duplicated, block: B:106:0x01c1  */
    /* JADX WARN: Code duplicated, block: B:156:0x02b1 A[ADDED_TO_REGION] */
    /* JADX WARN: Code duplicated, block: B:160:0x032d A[Catch: IOException -> 0x0473, TRY_ENTER, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:162:0x0332 A[Catch: IOException -> 0x0473, TRY_LEAVE, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:169:0x0341 A[ADDED_TO_REGION] */
    /* JADX WARN: Code duplicated, block: B:173:0x03bd A[Catch: IOException -> 0x0473, TRY_ENTER, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:175:0x03c2 A[Catch: IOException -> 0x0473, TRY_LEAVE, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:183:0x03d5 A[ADDED_TO_REGION] */
    /* JADX WARN: Code duplicated, block: B:188:0x045b A[Catch: all -> 0x0482, TryCatch #22 {all -> 0x0482, blocks: (B:181:0x03d1, B:184:0x03d7, B:185:0x03d9, B:186:0x044f, B:188:0x045b, B:190:0x0460, B:189:0x045e), top: B:235:0x03d1 }] */
    /* JADX WARN: Code duplicated, block: B:189:0x045e A[Catch: all -> 0x0482, TryCatch #22 {all -> 0x0482, blocks: (B:181:0x03d1, B:184:0x03d7, B:185:0x03d9, B:186:0x044f, B:188:0x045b, B:190:0x0460, B:189:0x045e), top: B:235:0x03d1 }] */
    /* JADX WARN: Code duplicated, block: B:193:0x0468 A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:194:0x046a A[Catch: all -> 0x046d, TRY_LEAVE, TryCatch #11 {all -> 0x046d, blocks: (B:192:0x0465, B:194:0x046a), top: B:231:0x0465 }] */
    /* JADX WARN: Code duplicated, block: B:196:0x046f A[Catch: IOException -> 0x0473, TRY_ENTER, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:200:0x0478 A[Catch: IOException -> 0x0473, TRY_LEAVE, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:210:0x0496 A[ADDED_TO_REGION] */
    /* JADX WARN: Code duplicated, block: B:214:0x0514 A[Catch: IOException -> 0x0473, TRY_ENTER, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:216:0x0519 A[Catch: IOException -> 0x0473, TRY_LEAVE, TryCatch #6 {IOException -> 0x0473, blocks: (B:123:0x027a, B:125:0x027f, B:160:0x032d, B:162:0x0332, B:173:0x03bd, B:175:0x03c2, B:196:0x046f, B:200:0x0478, B:214:0x0514, B:216:0x0519), top: B:230:0x0014 }] */
    /* JADX WARN: Code duplicated, block: B:231:0x0465 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:235:0x03d1 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r17v1, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r17v14 */
    /* JADX WARN: Type inference failed for: r17v15 */
    /* JADX WARN: Type inference failed for: r17v16 */
    /* JADX WARN: Type inference failed for: r17v17 */
    /* JADX WARN: Type inference failed for: r17v2 */
    /* JADX WARN: Type inference failed for: r17v26 */
    /* JADX WARN: Type inference failed for: r17v27 */
    /* JADX WARN: Type inference failed for: r17v28 */
    /* JADX WARN: Type inference failed for: r17v29 */
    /* JADX WARN: Type inference failed for: r17v3, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r17v4 */
    /* JADX WARN: Type inference failed for: r17v5, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r17v6 */
    /* JADX WARN: Type inference failed for: r17v7, types: [java.io.BufferedReader] */
    /* JADX WARN: Type inference failed for: r17v9 */
    /* JADX WARN: Type inference failed for: r18v0, types: [java.io.BufferedReader] */
    @Override // cn.com.chinatelecom.account.api.net.INet
    public ResponseInfo sendHttpsRequest(String str, String str2, int i, RequestConfig requestConfig, boolean z) throws Throwable {
        Throwable th;
        boolean z2;
        Throwable th2;
        boolean z3;
        IOException iOException;
        String strReplace;
        boolean z4;
        UnknownHostException unknownHostException;
        boolean z5;
        SocketTimeoutException socketTimeoutException;
        ?? r17;
        BufferedReader bufferedReader;
        ?? r18;
        BufferedReader bufferedReader2;
        ?? r19;
        BufferedReader bufferedReader3;
        ?? r110;
        InputStream inputStream;
        BufferedReader bufferedReader4;
        BufferedReader bufferedReader5;
        InputStream inputStream2;
        BufferedReader bufferedReader6;
        InputStream inputStream3;
        Object obj;
        Object obj2;
        InputStream inputStream4;
        Object obj3;
        BufferedReader bufferedReader7;
        int i2;
        ResponseInfo responseInfo = new ResponseInfo();
        boolean z6 = false;
        try {
            try {
                try {
                    boolean zIsMobileNet = NetUtil.isMobileNet(this.context);
                    boolean zIsIpConnect = isIpConnect(requestConfig.allowIpConnect, requestConfig.ipAddr);
                    if (zIsIpConnect) {
                        try {
                            try {
                                strReplace = str;
                                try {
                                    strReplace = strReplace.replace(requestConfig.domain, requestConfig.ipAddr);
                                } catch (UnknownHostException e) {
                                    e = e;
                                    unknownHostException = e;
                                    z4 = false;
                                    z6 = zIsIpConnect;
                                    inputStream = null;
                                    r110 = 0;
                                    if (!z) {
                                        try {
                                            if (!requestConfig.isRetry) {
                                                responseInfo.retryPreLogin = z4;
                                            }
                                            responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                            CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                        } catch (Throwable th3) {
                                            th = th3;
                                            ?? r111 = r110;
                                            InputStream inputStream5 = inputStream;
                                            if (r111 != 0) {
                                                try {
                                                    r111.close();
                                                } catch (IOException e2) {
                                                    e2.printStackTrace();
                                                    throw th;
                                                }
                                            }
                                            if (inputStream5 == null) {
                                                throw th;
                                            }
                                            inputStream5.close();
                                            throw th;
                                        }
                                    }
                                    if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                        responseInfo.retryPreLoginType = "1";
                                    } else {
                                        responseInfo.retryPreLoginType = "2";
                                    }
                                    responseInfo.retryPreLogin = true;
                                    if (r110 != 0) {
                                        try {
                                            r110.close();
                                            if (inputStream != null) {
                                                inputStream.close();
                                            }
                                        } catch (Throwable unused) {
                                            if (r110 != 0) {
                                                r110.close();
                                            }
                                            if (inputStream != null) {
                                                inputStream.close();
                                            }
                                            return responseInfo;
                                        }
                                    } else if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    if (r110 != 0) {
                                        r110.close();
                                    }
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    return responseInfo;
                                }
                            } catch (UnknownHostException e3) {
                                e = e3;
                                strReplace = str;
                                unknownHostException = e;
                                z4 = false;
                                z6 = zIsIpConnect;
                                inputStream = null;
                                r110 = 0;
                                if (!z) {
                                    if (!requestConfig.isRetry && z6) {
                                        responseInfo.retryPreLogin = z4;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                    CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                }
                                if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                    responseInfo.retryPreLoginType = "1";
                                } else {
                                    responseInfo.retryPreLoginType = "2";
                                }
                                responseInfo.retryPreLogin = true;
                                if (r110 != 0) {
                                    r110.close();
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                } else if (inputStream != null) {
                                    inputStream.close();
                                }
                                if (r110 != 0) {
                                    r110.close();
                                }
                                if (inputStream != null) {
                                    inputStream.close();
                                }
                                return responseInfo;
                            }
                        } catch (SocketTimeoutException e4) {
                            socketTimeoutException = e4;
                            z5 = false;
                        } catch (IOException e5) {
                            iOException = e5;
                            z3 = false;
                            z6 = zIsIpConnect;
                            bufferedReader2 = null;
                            r18 = 0;
                            if (!requestConfig.isRetry && z6) {
                                responseInfo.retryPreLogin = z3;
                            }
                            responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                            CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                            if (bufferedReader2 != null) {
                                bufferedReader2.close();
                            }
                            if (r18 != 0) {
                                r18.close();
                            }
                            return responseInfo;
                        } catch (Throwable th4) {
                            th2 = th4;
                            z2 = false;
                            z6 = zIsIpConnect;
                            bufferedReader = null;
                            r17 = 0;
                            if (!requestConfig.isRetry && z6) {
                                responseInfo.retryPreLogin = z2;
                            }
                            responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                            CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                            if (bufferedReader != null) {
                                bufferedReader.close();
                            }
                            if (r17 != 0) {
                                r17.close();
                            }
                            return responseInfo;
                        }
                    } else {
                        strReplace = str;
                    }
                    try {
                        if (requestConfig.redirectCount > 0 && !zIsMobileNet && !isOsV5()) {
                            redirectUrlToRoute(this.context, strReplace);
                        }
                        HttpsURLConnection httpsURLConnectionCreateHttpsConnection = createHttpsConnection(strReplace, str2, i, requestConfig);
                        int responseCode = httpsURLConnectionCreateHttpsConnection.getResponseCode();
                        if (responseCode == 200) {
                            try {
                                inputStream3 = httpsURLConnectionCreateHttpsConnection.getInputStream();
                                try {
                                    StringBuilder sb = new StringBuilder();
                                    BufferedReader bufferedReader8 = new BufferedReader(new InputStreamReader(inputStream3));
                                    while (true) {
                                        try {
                                            String line = bufferedReader8.readLine();
                                            if (line == null) {
                                                break;
                                            }
                                            sb.append(line).append("\n");
                                        } catch (SocketTimeoutException e6) {
                                            r19 = inputStream3;
                                            bufferedReader3 = bufferedReader8;
                                            z5 = false;
                                            z6 = zIsIpConnect;
                                            socketTimeoutException = e6;
                                            if (!requestConfig.isRetry) {
                                                responseInfo.retryPreLogin = z5;
                                            }
                                            responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException : " + socketTimeoutException.getMessage());
                                            CtAuth.warn(TAG, "STE_" + requestConfig.apiFlag + "_" + socketTimeoutException.getMessage(), socketTimeoutException);
                                            if (bufferedReader3 != null) {
                                                bufferedReader3.close();
                                            }
                                            if (r19 != 0) {
                                                r19.close();
                                            }
                                        } catch (UnknownHostException e7) {
                                            inputStream = inputStream3;
                                            r110 = bufferedReader8;
                                            z4 = false;
                                            z6 = zIsIpConnect;
                                            unknownHostException = e7;
                                            if (!z) {
                                                if (!requestConfig.isRetry) {
                                                    responseInfo.retryPreLogin = z4;
                                                }
                                                responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                                CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                            }
                                            if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                                responseInfo.retryPreLoginType = "1";
                                            } else {
                                                responseInfo.retryPreLoginType = "2";
                                            }
                                            responseInfo.retryPreLogin = true;
                                            if (r110 != 0) {
                                                r110.close();
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                            } else if (inputStream != null) {
                                                inputStream.close();
                                            }
                                            if (r110 != 0) {
                                                r110.close();
                                            }
                                            if (inputStream != null) {
                                                inputStream.close();
                                            }
                                        } catch (IOException e8) {
                                            r18 = inputStream3;
                                            bufferedReader2 = bufferedReader8;
                                            z3 = false;
                                            z6 = zIsIpConnect;
                                            iOException = e8;
                                            if (!requestConfig.isRetry) {
                                                responseInfo.retryPreLogin = z3;
                                            }
                                            responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                                            CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                            if (bufferedReader2 != null) {
                                                bufferedReader2.close();
                                            }
                                            if (r18 != 0) {
                                                r18.close();
                                            }
                                        } catch (Throwable th5) {
                                            r17 = inputStream3;
                                            bufferedReader = bufferedReader8;
                                            z2 = false;
                                            z6 = zIsIpConnect;
                                            th2 = th5;
                                            if (!requestConfig.isRetry) {
                                                responseInfo.retryPreLogin = z2;
                                            }
                                            responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                                            CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                                            if (bufferedReader != null) {
                                                bufferedReader.close();
                                            }
                                            if (r17 != 0) {
                                                r17.close();
                                            }
                                        }
                                    }
                                    responseInfo.errorCode = 0;
                                    String string = sb.toString();
                                    if (!TextUtils.isEmpty(string)) {
                                        responseInfo.result = new JSONObject(string);
                                        LogUtils.putExLog(requestConfig.reqId, responseInfo.result, null);
                                    }
                                    HeaderParams responesHeaderFor200 = ApiUtils.getResponesHeaderFor200(this.context, httpsURLConnectionCreateHttpsConnection, true);
                                    if (responesHeaderFor200 != null) {
                                        responseInfo.gwAuth = responesHeaderFor200.gw_auth;
                                        LogUtils.build(requestConfig.reqId).setOperatorType(responesHeaderFor200.operatorType);
                                    }
                                    if (responesHeaderFor200.dmSwitch && z) {
                                        if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                            responseInfo.retryPreLoginType = "1";
                                        } else {
                                            responseInfo.retryPreLoginType = "2";
                                        }
                                        responseInfo.retryPreLogin = true;
                                    }
                                    if (!z) {
                                        if (strReplace.contains(Xor.de(Constants.paramsId6Domain))) {
                                            NetUtil.saveRequestDomainTypeTime(this.context, 0L);
                                        } else {
                                            NetUtil.saveRequestDomainType(this.context, "2");
                                            NetUtil.saveRequestDomainTypeTime(this.context, System.currentTimeMillis());
                                        }
                                    }
                                    bufferedReader7 = bufferedReader8;
                                } catch (SocketTimeoutException e9) {
                                    obj3 = inputStream3;
                                    bufferedReader3 = null;
                                    socketTimeoutException = e9;
                                    z5 = false;
                                    z6 = zIsIpConnect;
                                    r19 = obj3;
                                } catch (UnknownHostException e10) {
                                    inputStream = inputStream3;
                                    inputStream4 = null;
                                    unknownHostException = e10;
                                    z4 = false;
                                    z6 = zIsIpConnect;
                                    r110 = inputStream4;
                                    if (!z) {
                                        if (!requestConfig.isRetry) {
                                            responseInfo.retryPreLogin = z4;
                                        }
                                        responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                        LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                        CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                    }
                                    if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                        responseInfo.retryPreLoginType = "1";
                                    } else {
                                        responseInfo.retryPreLoginType = "2";
                                    }
                                    responseInfo.retryPreLogin = true;
                                    if (r110 != 0) {
                                        r110.close();
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                    } else if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    if (r110 != 0) {
                                        r110.close();
                                    }
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    return responseInfo;
                                } catch (IOException e11) {
                                    obj2 = inputStream3;
                                    bufferedReader2 = null;
                                    iOException = e11;
                                    z3 = false;
                                    z6 = zIsIpConnect;
                                    r18 = obj2;
                                    if (!requestConfig.isRetry) {
                                        responseInfo.retryPreLogin = z3;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                                    CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                    if (bufferedReader2 != null) {
                                        bufferedReader2.close();
                                    }
                                    if (r18 != 0) {
                                        r18.close();
                                    }
                                    return responseInfo;
                                } catch (Throwable th6) {
                                    obj = inputStream3;
                                    bufferedReader = null;
                                    th2 = th6;
                                    z2 = false;
                                    z6 = zIsIpConnect;
                                    r17 = obj;
                                    if (!requestConfig.isRetry) {
                                        responseInfo.retryPreLogin = z2;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                                    CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                                    if (bufferedReader != null) {
                                        bufferedReader.close();
                                    }
                                    if (r17 != 0) {
                                        r17.close();
                                    }
                                    return responseInfo;
                                }
                            } catch (SocketTimeoutException e12) {
                                e = e12;
                                bufferedReader6 = null;
                                socketTimeoutException = e;
                                bufferedReader3 = bufferedReader6;
                                obj3 = bufferedReader3;
                                z5 = false;
                                z6 = zIsIpConnect;
                                r19 = obj3;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z5;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException : " + socketTimeoutException.getMessage());
                                CtAuth.warn(TAG, "STE_" + requestConfig.apiFlag + "_" + socketTimeoutException.getMessage(), socketTimeoutException);
                                if (bufferedReader3 != null) {
                                    bufferedReader3.close();
                                }
                                if (r19 != 0) {
                                    r19.close();
                                }
                                return responseInfo;
                            } catch (UnknownHostException e13) {
                                e = e13;
                                inputStream2 = null;
                                unknownHostException = e;
                                inputStream = inputStream2;
                                inputStream4 = inputStream;
                                z4 = false;
                                z6 = zIsIpConnect;
                                r110 = inputStream4;
                                if (!z) {
                                    if (!requestConfig.isRetry) {
                                        responseInfo.retryPreLogin = z4;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                    CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                }
                                if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                    responseInfo.retryPreLoginType = "1";
                                } else {
                                    responseInfo.retryPreLoginType = "2";
                                }
                                responseInfo.retryPreLogin = true;
                                if (r110 != 0) {
                                    r110.close();
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                } else if (inputStream != null) {
                                    inputStream.close();
                                }
                                if (r110 != 0) {
                                    r110.close();
                                }
                                if (inputStream != null) {
                                    inputStream.close();
                                }
                                return responseInfo;
                            } catch (IOException e14) {
                                e = e14;
                                bufferedReader5 = null;
                                iOException = e;
                                bufferedReader2 = bufferedReader5;
                                obj2 = bufferedReader2;
                                z3 = false;
                                z6 = zIsIpConnect;
                                r18 = obj2;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z3;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                                CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                if (bufferedReader2 != null) {
                                    bufferedReader2.close();
                                }
                                if (r18 != 0) {
                                    r18.close();
                                }
                                return responseInfo;
                            } catch (Throwable th7) {
                                th = th7;
                                bufferedReader4 = null;
                                th2 = th;
                                bufferedReader = bufferedReader4;
                                obj = bufferedReader;
                                z2 = false;
                                z6 = zIsIpConnect;
                                r17 = obj;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z2;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                                CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                                if (bufferedReader != null) {
                                    bufferedReader.close();
                                }
                                if (r17 != 0) {
                                    r17.close();
                                }
                                return responseInfo;
                            }
                        } else {
                            z2 = false;
                            bufferedReader6 = null;
                            inputStream2 = null;
                            bufferedReader5 = null;
                            bufferedReader4 = null;
                            z5 = false;
                            z4 = false;
                            z3 = false;
                            try {
                                if (responseCode == 302) {
                                    if (requestConfig.redirectCount < 10) {
                                        requestConfig.redirectCount++;
                                        requestConfig.allowIpConnect = false;
                                        String headerField = httpsURLConnectionCreateHttpsConnection.getHeaderField("Location");
                                        HeaderParams responesHeaderFor302 = ApiUtils.getResponesHeaderFor302(httpsURLConnectionCreateHttpsConnection);
                                        LogUtils.build(requestConfig.reqId).setOperatorType(responesHeaderFor302.operatorType).setNetState(NetUtil.getNetStateForLog(this.context));
                                        if (TextUtils.isEmpty(responesHeaderFor302.redirectRequestMethod)) {
                                            i2 = 0;
                                        } else {
                                            try {
                                                if (responesHeaderFor302.redirectRequestMethod.equals("0")) {
                                                    i2 = 0;
                                                } else {
                                                    i2 = 1;
                                                }
                                            } catch (SocketTimeoutException e15) {
                                                e = e15;
                                                socketTimeoutException = e;
                                                bufferedReader3 = bufferedReader6;
                                                obj3 = bufferedReader3;
                                                z5 = false;
                                                z6 = zIsIpConnect;
                                                r19 = obj3;
                                                if (!requestConfig.isRetry) {
                                                    responseInfo.retryPreLogin = z5;
                                                }
                                                responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException : " + socketTimeoutException.getMessage());
                                                CtAuth.warn(TAG, "STE_" + requestConfig.apiFlag + "_" + socketTimeoutException.getMessage(), socketTimeoutException);
                                                if (bufferedReader3 != null) {
                                                    bufferedReader3.close();
                                                }
                                                if (r19 != 0) {
                                                    r19.close();
                                                }
                                                return responseInfo;
                                            } catch (UnknownHostException e16) {
                                                e = e16;
                                                unknownHostException = e;
                                                inputStream = inputStream2;
                                                inputStream4 = inputStream;
                                                z4 = false;
                                                z6 = zIsIpConnect;
                                                r110 = inputStream4;
                                                if (!z) {
                                                    if (!requestConfig.isRetry) {
                                                        responseInfo.retryPreLogin = z4;
                                                    }
                                                    responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                                    CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                                }
                                                if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                                    responseInfo.retryPreLoginType = "1";
                                                } else {
                                                    responseInfo.retryPreLoginType = "2";
                                                }
                                                responseInfo.retryPreLogin = true;
                                                if (r110 != 0) {
                                                    r110.close();
                                                    if (inputStream != null) {
                                                        inputStream.close();
                                                    }
                                                } else if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                if (r110 != 0) {
                                                    r110.close();
                                                }
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                return responseInfo;
                                            } catch (IOException e17) {
                                                e = e17;
                                                iOException = e;
                                                bufferedReader2 = bufferedReader5;
                                                obj2 = bufferedReader2;
                                                z3 = false;
                                                z6 = zIsIpConnect;
                                                r18 = obj2;
                                                if (!requestConfig.isRetry) {
                                                    responseInfo.retryPreLogin = z3;
                                                }
                                                responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                                                CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                                if (bufferedReader2 != null) {
                                                    bufferedReader2.close();
                                                }
                                                if (r18 != 0) {
                                                    r18.close();
                                                }
                                                return responseInfo;
                                            } catch (Throwable th8) {
                                                th = th8;
                                                th2 = th;
                                                bufferedReader = bufferedReader4;
                                                obj = bufferedReader;
                                                z2 = false;
                                                z6 = zIsIpConnect;
                                                r17 = obj;
                                                if (!requestConfig.isRetry) {
                                                    responseInfo.retryPreLogin = z2;
                                                }
                                                responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                                                CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                                                if (bufferedReader != null) {
                                                    bufferedReader.close();
                                                }
                                                if (r17 != 0) {
                                                    r17.close();
                                                }
                                                return responseInfo;
                                            }
                                        }
                                        CtAuth.info(TAG, "method : " + i2);
                                        return sendRequest(headerField, null, i2, requestConfig, false);
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-Redirect more than 10 times");
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Redirect more than 10 times");
                                    socketTimeoutException = e;
                                    z6 = zIsIpConnect;
                                    bufferedReader3 = null;
                                    r19 = 0;
                                    if (!requestConfig.isRetry && z6) {
                                        responseInfo.retryPreLogin = z5;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException : " + socketTimeoutException.getMessage());
                                    CtAuth.warn(TAG, "STE_" + requestConfig.apiFlag + "_" + socketTimeoutException.getMessage(), socketTimeoutException);
                                    if (bufferedReader3 != null) {
                                        bufferedReader3.close();
                                    }
                                    if (r19 != 0) {
                                        r19.close();
                                    }
                                    return responseInfo;
                                }
                                if (!z) {
                                    NetUtil.saveRequestDomainTypeTime(this.context, 0L);
                                    responseInfo.result = ResultUtils.toJsonResult(80002, Xor.de(ResultUtils.MSG_RESPONSE_CODE_ERROR) + "-" + requestConfig.apiFlag + "-code : " + responseCode);
                                    String str3 = "response code ：" + responseCode;
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, str3);
                                    CtAuth.info(TAG, str3);
                                    return responseInfo;
                                }
                                if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                    responseInfo.retryPreLoginType = "1";
                                } else {
                                    responseInfo.retryPreLoginType = "2";
                                }
                                responseInfo.retryPreLogin = true;
                                inputStream3 = null;
                                bufferedReader7 = null;
                            } catch (SocketTimeoutException e18) {
                                e = e18;
                                socketTimeoutException = e;
                                z6 = zIsIpConnect;
                                bufferedReader3 = null;
                                r19 = 0;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z5;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException : " + socketTimeoutException.getMessage());
                                CtAuth.warn(TAG, "STE_" + requestConfig.apiFlag + "_" + socketTimeoutException.getMessage(), socketTimeoutException);
                                if (bufferedReader3 != null) {
                                    bufferedReader3.close();
                                }
                                if (r19 != 0) {
                                    r19.close();
                                }
                            } catch (UnknownHostException e19) {
                                e = e19;
                                unknownHostException = e;
                                z6 = zIsIpConnect;
                                inputStream = null;
                                r110 = 0;
                                if (!z) {
                                    if (!requestConfig.isRetry) {
                                        responseInfo.retryPreLogin = z4;
                                    }
                                    responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException : " + unknownHostException.getMessage());
                                    CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                }
                                if (strReplace.contains(Xor.de(Constants.paramsCardDomain))) {
                                    responseInfo.retryPreLoginType = "1";
                                } else {
                                    responseInfo.retryPreLoginType = "2";
                                }
                                responseInfo.retryPreLogin = true;
                                if (r110 != 0) {
                                    r110.close();
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                } else if (inputStream != null) {
                                    inputStream.close();
                                }
                                if (r110 != 0) {
                                    r110.close();
                                }
                                if (inputStream != null) {
                                    inputStream.close();
                                }
                            } catch (IOException e20) {
                                e = e20;
                                iOException = e;
                                z6 = zIsIpConnect;
                                bufferedReader2 = null;
                                r18 = 0;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z3;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException : " + iOException.getMessage());
                                CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                if (bufferedReader2 != null) {
                                    bufferedReader2.close();
                                }
                                if (r18 != 0) {
                                    r18.close();
                                }
                            } catch (Throwable th9) {
                                th = th9;
                                th2 = th;
                                z6 = zIsIpConnect;
                                bufferedReader = null;
                                r17 = 0;
                                if (!requestConfig.isRetry) {
                                    responseInfo.retryPreLogin = z2;
                                }
                                responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th2.getMessage());
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable : " + th2.getMessage());
                                CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th2.getMessage(), th2);
                                if (bufferedReader != null) {
                                    bufferedReader.close();
                                }
                                if (r17 != 0) {
                                    r17.close();
                                }
                            }
                        }
                        if (bufferedReader7 != null) {
                            bufferedReader7.close();
                        }
                        if (inputStream3 != null) {
                            inputStream3.close();
                        }
                    } catch (SocketTimeoutException e21) {
                        e = e21;
                        z5 = false;
                    } catch (UnknownHostException e22) {
                        e = e22;
                        z4 = false;
                    } catch (IOException e23) {
                        e = e23;
                        z3 = false;
                    } catch (Throwable th10) {
                        th = th10;
                        z2 = false;
                    }
                } catch (IOException e24) {
                    e24.printStackTrace();
                }
            } catch (SocketTimeoutException e25) {
                z5 = false;
                socketTimeoutException = e25;
            } catch (UnknownHostException e26) {
                strReplace = str;
                z4 = false;
                unknownHostException = e26;
            } catch (IOException e27) {
                z3 = false;
                iOException = e27;
            } catch (Throwable th11) {
                z2 = false;
                th2 = th11;
            }
            return responseInfo;
        } catch (Throwable th12) {
            th = th12;
        }
    }

    /* JADX WARN: Code duplicated, block: B:100:0x03bb A[Catch: IOException -> 0x03b6, TRY_LEAVE, TryCatch #0 {IOException -> 0x03b6, blocks: (B:96:0x03b2, B:100:0x03bb), top: B:104:0x03b2 }] */
    /* JADX WARN: Code duplicated, block: B:104:0x03b2 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:117:? A[SYNTHETIC] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r12v10 */
    /* JADX WARN: Type inference failed for: r12v15 */
    /* JADX WARN: Type inference failed for: r12v2 */
    /* JADX WARN: Type inference failed for: r12v3, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r12v4, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v0, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r1v12, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v13, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v14 */
    /* JADX WARN: Type inference failed for: r1v15, types: [java.io.InputStream] */
    /* JADX WARN: Type inference failed for: r1v3 */
    /* JADX WARN: Type inference failed for: r1v4 */
    /* JADX WARN: Type inference failed for: r1v42 */
    /* JADX WARN: Type inference failed for: r1v43 */
    /* JADX WARN: Type inference failed for: r1v44 */
    /* JADX WARN: Type inference failed for: r1v45 */
    /* JADX WARN: Type inference failed for: r1v46 */
    /* JADX WARN: Type inference failed for: r1v47 */
    /* JADX WARN: Type inference failed for: r1v5 */
    /* JADX WARN: Type inference failed for: r1v6 */
    @Override // cn.com.chinatelecom.account.api.net.INet
    public ResponseInfo sendHttpRequest(String str, String str2, int i, RequestConfig requestConfig) throws Throwable {
        Throwable th;
        BufferedReader bufferedReader;
        IOException iOException;
        UnknownHostException unknownHostException;
        SocketTimeoutException socketTimeoutException;
        Throwable th2;
        InputStream inputStream;
        ?? r1 = " method : ";
        ResponseInfo responseInfo = new ResponseInfo();
        BufferedReader bufferedReader2 = null;
        bufferedReader2 = null;
        bufferedReader2 = null;
        bufferedReader2 = null;
        BufferedReader bufferedReader3 = null;
        bufferedReader2 = null;
        bufferedReader2 = null;
        bufferedReader2 = null;
        ?? r12 = 0;
        try {
            try {
                try {
                    HttpURLConnection httpURLConnectionCreateHttpConnection = createHttpConnection(str, str2, i, requestConfig);
                    int responseCode = httpURLConnectionCreateHttpConnection.getResponseCode();
                    if (responseCode == 200) {
                        InputStream inputStream2 = httpURLConnectionCreateHttpConnection.getInputStream();
                        try {
                            StringBuilder sb = new StringBuilder();
                            bufferedReader = new BufferedReader(new InputStreamReader(inputStream2));
                            while (true) {
                                try {
                                    String line = bufferedReader.readLine();
                                    if (line == null) {
                                        break;
                                    }
                                    sb.append(line).append("\n");
                                } catch (SocketTimeoutException e) {
                                    socketTimeoutException = e;
                                    bufferedReader2 = bufferedReader;
                                    r1 = inputStream2;
                                    responseInfo.result = ResultUtils.toJsonResult(80005, Xor.de(ResultUtils.MSG_SOCKET_TIMEOUT_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage());
                                    CtAuth.warn(TAG, "SocketTimeoutException-" + requestConfig.apiFlag + "-" + socketTimeoutException.getMessage(), socketTimeoutException);
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "SocketTimeoutException ：" + socketTimeoutException.getMessage());
                                    if (bufferedReader2 != null) {
                                        bufferedReader2.close();
                                    }
                                    if (r1 != 0) {
                                        r1.close();
                                    }
                                } catch (UnknownHostException e2) {
                                    unknownHostException = e2;
                                    bufferedReader2 = bufferedReader;
                                    r1 = inputStream2;
                                    responseInfo.result = ResultUtils.toJsonResult(80006, Xor.de(ResultUtils.MSG_UNKNOWN_HOST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage());
                                    CtAuth.warn(TAG, "UnknownHostException-" + requestConfig.apiFlag + "-" + unknownHostException.getMessage(), unknownHostException);
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "UnknownHostException ：" + unknownHostException.getMessage());
                                    if (bufferedReader2 != null) {
                                        bufferedReader2.close();
                                    }
                                    if (r1 != 0) {
                                        r1.close();
                                    }
                                } catch (IOException e3) {
                                    iOException = e3;
                                    bufferedReader2 = bufferedReader;
                                    r1 = inputStream2;
                                    responseInfo.result = ResultUtils.toJsonResult(ResultUtils.CODE_IO_EXCEPTION, Xor.de(ResultUtils.MSG_IO_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + iOException.getMessage());
                                    CtAuth.warn(TAG, "IOException-" + requestConfig.apiFlag + "-" + iOException.getMessage(), iOException);
                                    LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "IOException ：" + iOException.getMessage());
                                    if (bufferedReader2 != null) {
                                        bufferedReader2.close();
                                    }
                                    if (r1 != 0) {
                                        r1.close();
                                    }
                                } catch (Throwable th3) {
                                    th = th3;
                                    r12 = inputStream2;
                                    th = th;
                                    try {
                                        responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-" + requestConfig.apiFlag + "-" + th.getMessage());
                                        CtAuth.warn(TAG, "Throwable-" + requestConfig.apiFlag + "-" + th.getMessage(), th);
                                        LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Throwable ：" + th.getMessage());
                                        if (bufferedReader != null) {
                                            bufferedReader.close();
                                        }
                                        if (r12 != 0) {
                                            r12.close();
                                        }
                                    } catch (Throwable th4) {
                                        th = th4;
                                        th2 = th;
                                        if (bufferedReader != null) {
                                            try {
                                                bufferedReader.close();
                                            } catch (IOException e4) {
                                                e4.printStackTrace();
                                                throw th2;
                                            }
                                        }
                                        if (r12 != 0) {
                                            throw th2;
                                        }
                                        r12.close();
                                        throw th2;
                                    }
                                }
                            }
                            responseInfo.errorCode = 0;
                            String string = sb.toString();
                            if (!TextUtils.isEmpty(string)) {
                                responseInfo.result = new JSONObject(string);
                                LogUtils.putExLog(requestConfig.reqId, responseInfo.result, null);
                            }
                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, null);
                            HeaderParams responesHeaderFor200 = ApiUtils.getResponesHeaderFor200(this.context, httpURLConnectionCreateHttpConnection, true);
                            if (responesHeaderFor200 != null) {
                                responseInfo.gwAuth = responesHeaderFor200.gw_auth;
                                responseInfo.retryPreLogin = responesHeaderFor200.dmSwitch;
                                LogUtils.build(requestConfig.reqId).setOperatorType(responesHeaderFor200.operatorType).setNetState(NetUtil.getNetStateForLog(this.context));
                            }
                            bufferedReader3 = bufferedReader;
                            inputStream = inputStream2;
                        } catch (SocketTimeoutException e5) {
                            socketTimeoutException = e5;
                            r1 = inputStream2;
                        } catch (UnknownHostException e6) {
                            unknownHostException = e6;
                            r1 = inputStream2;
                        } catch (IOException e7) {
                            iOException = e7;
                            r1 = inputStream2;
                        } catch (Throwable th5) {
                            th = th5;
                            bufferedReader = null;
                        }
                    } else {
                        if (responseCode != 302) {
                            responseInfo.result = ResultUtils.toJsonResult(80002, Xor.de(ResultUtils.MSG_RESPONSE_CODE_ERROR) + "-" + requestConfig.apiFlag + "-code : " + responseCode);
                            String str3 = " Http response code :" + responseCode;
                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, str3);
                            CtAuth.info(TAG, str3);
                        } else {
                            if (requestConfig.redirectCount < 10) {
                                requestConfig.redirectCount++;
                                requestConfig.allowIpConnect = false;
                                String headerField = httpURLConnectionCreateHttpConnection.getHeaderField("Location");
                                HeaderParams responesHeaderFor302 = ApiUtils.getResponesHeaderFor302(httpURLConnectionCreateHttpConnection);
                                LogUtils.build(requestConfig.reqId).setOperatorType(responesHeaderFor302.operatorType).setNetState(NetUtil.getNetStateForLog(this.context));
                                int i2 = (TextUtils.isEmpty(responesHeaderFor302.redirectRequestMethod) || responesHeaderFor302.redirectRequestMethod.equals("0")) ? 0 : 1;
                                CtAuth.info(TAG, " method : " + i2);
                                return sendRequest(headerField, null, i2, requestConfig, false);
                            }
                            responseInfo.result = ResultUtils.toJsonResult(80001, Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "-Redirect more than 10 times");
                            LogUtils.putExLog(requestConfig.reqId, responseInfo.result, "Redirect more than 10 times");
                        }
                        inputStream = null;
                    }
                    if (bufferedReader3 != null) {
                        bufferedReader3.close();
                    }
                    if (inputStream != null) {
                        inputStream.close();
                    }
                } catch (Throwable th6) {
                    th = th6;
                    bufferedReader = bufferedReader2;
                    r12 = r1;
                    th2 = th;
                    if (bufferedReader != null) {
                        bufferedReader.close();
                    }
                    if (r12 != 0) {
                        throw th2;
                    }
                    r12.close();
                    throw th2;
                }
            } catch (SocketTimeoutException e8) {
                socketTimeoutException = e8;
                r1 = 0;
            } catch (UnknownHostException e9) {
                unknownHostException = e9;
                r1 = 0;
            } catch (IOException e10) {
                iOException = e10;
                r1 = 0;
            } catch (Throwable th7) {
                th = th7;
                bufferedReader = null;
            }
        } catch (IOException e11) {
            e11.printStackTrace();
        }
        return responseInfo;
    }
}
