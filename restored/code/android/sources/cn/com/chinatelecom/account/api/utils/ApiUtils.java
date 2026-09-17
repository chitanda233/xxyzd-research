package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import android.net.Network;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.CtSdkApi;
import cn.com.chinatelecom.account.api.net.CtAuthNetworkRequest;
import cn.com.chinatelecom.account.api.net.HeaderParams;
import cn.com.chinatelecom.account.api.net.RequestConfig;
import cn.com.chinatelecom.account.api.net.ResponseInfo;
import com.alipay.sdk.m.y.l;
import com.alipay.sdk.m.y.o;
import com.kuaishou.weapon.p0.t;
import java.net.HttpURLConnection;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public final class ApiUtils {
    private static final String TAG = "ApiUtils";
    private static HashMap<String, String> gwAuthMap = new HashMap<>();

    public static JSONObject parsePreCodeResult(Context context, ResponseInfo responseInfo, String str, Network network, boolean z, String str2) {
        if (responseInfo == null || responseInfo.result == null) {
            return ResultUtils.getRequestExceptionJson();
        }
        JSONObject jSONObject = responseInfo.result;
        try {
            if (responseInfo.errorCode != -1 && !TextUtils.isEmpty(str)) {
                int iOptInt = jSONObject.optInt(o.c);
                String strOptString = jSONObject.optString("data");
                if (!TextUtils.isEmpty(strOptString)) {
                    try {
                        String strDecryptPreLoginResult = ParamFactory.decryptPreLoginResult(strOptString, str);
                        if (strDecryptPreLoginResult.isEmpty()) {
                            jSONObject.put(o.c, ResultUtils.CODE_ENCRYPT_EXCEPTION);
                            jSONObject.put("msg", cn.com.chinatelecom.account.api.encrypt.Xor.de(ResultUtils.MSG_CODE_ENCRYPT_EXCEPTION));
                        } else {
                            JSONObject jSONObject2 = new JSONObject(strDecryptPreLoginResult);
                            if (iOptInt == 0) {
                                jSONObject2.put("gwAuth", responseInfo.gwAuth);
                            }
                            if (iOptInt == -10020) {
                                jSONObject.put("taskId", str);
                            }
                            jSONObject.put("data", jSONObject2);
                        }
                    } catch (Throwable th) {
                        CtAuth.warn(TAG, "dct", th);
                        jSONObject.put(o.c, ResultUtils.CODE_ENCRYPT_EXCEPTION);
                        jSONObject.put("msg", cn.com.chinatelecom.account.api.encrypt.Xor.de(ResultUtils.MSG_CODE_ENCRYPT_EXCEPTION));
                        jSONObject.put("data", (Object) null);
                    }
                }
                if (iOptInt != 30002 || !z) {
                    if (iOptInt == -10009 || iOptInt == -30001) {
                        long jOptLong = jSONObject.optLong("timeStamp", -1L);
                        if (jOptLong == -1) {
                            requestTimeStampFromServer(context);
                        } else {
                            saveDifferenceTimeForServer(context, jOptLong);
                        }
                    }
                    return jSONObject;
                }
                JSONObject jSONObject3 = (JSONObject) jSONObject.opt("data");
                ArrayList arrayList = new ArrayList();
                JSONArray jSONArrayOptJSONArray = jSONObject3.optJSONArray("urls");
                if (jSONArrayOptJSONArray != null) {
                    for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                        arrayList.add(jSONArrayOptJSONArray.getString(i));
                    }
                }
                if (arrayList.isEmpty()) {
                    return null;
                }
                return preGetMobileUrls(context, arrayList, str, network, str2);
            }
            return jSONObject;
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static JSONObject preGetMobileUrls(Context context, List<String> list, String str, Network network, String str2) {
        for (int i = 0; i < list.size(); i++) {
            try {
                String str3 = list.get(i);
                if (!TextUtils.isEmpty(str3)) {
                    NetUtil.isMobileNet(context);
                    RequestConfig.Builder builder = new RequestConfig.Builder();
                    try {
                        builder.setRequestId(str2);
                        try {
                            builder.setNetwork(network);
                            try {
                                JSONObject preCodeResult = parsePreCodeResult(context, new CtAuthNetworkRequest(context).sendRequest(str3, "", 0, builder.build(), false), str, network, false, str2);
                                if (preCodeResult != null && preCodeResult.optInt(o.c) == 0) {
                                    return preCodeResult;
                                }
                            } catch (Throwable th) {
                                th = th;
                                th.printStackTrace();
                            }
                        } catch (Throwable th2) {
                            th = th2;
                        }
                    } catch (Throwable th3) {
                        th = th3;
                    }
                }
            } catch (Throwable th4) {
                th = th4;
            }
        }
        return ResultUtils.toJsonResult(80001, cn.com.chinatelecom.account.api.encrypt.Xor.de(ResultUtils.MSG_REQUEST_EXCEPTION) + "- redirect 30002 ");
    }

    public static long getTimeDiff(Context context) {
        return DefaultShared.getLong(context, DefaultShared.KEY_DIFFERENCE_TIME_FOR_SERVER, 0L);
    }

    private static void saveDifferenceTimeForServer(Context context, long j) {
        if (j > 0) {
            DefaultShared.putLong(context, DefaultShared.KEY_DIFFERENCE_TIME_FOR_SERVER, j - System.currentTimeMillis());
        }
    }

    private static void requestTimeStampFromServer(Context context) {
        String requestId = DeviceInfoUtil.getRequestId();
        RequestConfig.Builder builder = new RequestConfig.Builder();
        builder.setApiFlag("reqTimestamp");
        builder.setRequestId(requestId);
        JSONObject jSONObject = new CtAuthNetworkRequest(context).sendRequest(NetUtil.getGetTimestampUrl(), "", 1, builder.build(), false).result;
        if (jSONObject != null) {
            saveDifferenceTimeForServer(context, jSONObject.optLong("msg", -1L));
        }
    }

    public static void saveGwAuth(String str, String str2) {
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
            return;
        }
        gwAuthMap.put(str, str2);
    }

    public static String getGwAuth(String str) {
        return (TextUtils.isEmpty(str) || !gwAuthMap.containsKey(str)) ? "" : gwAuthMap.get(str);
    }

    public static synchronized String getApiFlagByPreLogin(int i) {
        return i == CtSdkApi.AUTH_ONEKEY ? Constants.API_FLAG_PRESDK : Constants.API_FLAG_BIOM;
    }

    public static HeaderParams getResponesHeaderFor200(Context context, HttpURLConnection httpURLConnection, boolean z) {
        String str;
        if (!z) {
            return null;
        }
        HeaderParams headerParams = new HeaderParams();
        try {
            Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
            List<String> list = headerFields.get(t.b);
            if (list != null && list.size() > 0) {
                CtAuth.info(TAG, "request protocol : " + list.get(0));
                headerParams.isSwitchProtocol = false;
            }
            List<String> list2 = headerFields.get("Set-Cookie");
            if (list2 != null && list2.size() > 0) {
                for (int i = 0; i < list2.size(); i++) {
                    String str2 = list2.get(0);
                    if (!TextUtils.isEmpty(str2) && str2.contains("gw_auth")) {
                        headerParams.gw_auth = getGwAuth(str2, "gw_auth");
                        break;
                    }
                }
            }
            List<String> list3 = headerFields.get("Log-Level");
            if (list3 != null && !list3.isEmpty()) {
                for (int i2 = 0; i2 < list3.size(); i2++) {
                    String str3 = list3.get(0);
                    if (!TextUtils.isEmpty(str3)) {
                        LogUtils.setLogControl(context, str3);
                    }
                }
            }
            List<String> list4 = headerFields.get("p-reset");
            if (list4 != null && !list4.isEmpty()) {
                String str4 = list4.get(0);
                if (!TextUtils.isEmpty(str4)) {
                    savePageReset(context, str4);
                }
            }
            List<String> list5 = headerFields.get("p-ikgx");
            if (list5 != null && !list5.isEmpty()) {
                String str5 = list5.get(0);
                if (!TextUtils.isEmpty(str5)) {
                    headerParams.operatorType = str5;
                    NetUtil.operatorType = str5;
                }
            }
            List<String> list6 = headerFields.get(t.v);
            if (list6 != null && !list6.isEmpty() && (str = list6.get(0)) != null && (str.equals("1") || str.equals("2"))) {
                String requestDomainType = NetUtil.getRequestDomainType(context);
                if ((!TextUtils.isEmpty(requestDomainType) && !requestDomainType.equals(str)) || (TextUtils.isEmpty(requestDomainType) && str.equals("2"))) {
                    headerParams.dmSwitch = true;
                }
                NetUtil.saveRequestDomainType(context, str);
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
        return headerParams;
    }

    public static HeaderParams getResponesHeaderFor302(HttpURLConnection httpURLConnection) {
        HeaderParams headerParams = new HeaderParams();
        try {
            Map<String, List<String>> headerFields = httpURLConnection.getHeaderFields();
            List<String> list = headerFields.get("rdt_allow");
            if (list != null && list.size() > 0) {
                headerParams.redirectRequestMethod = list.get(0);
                CtAuth.info(TAG, "request method : " + headerParams.redirectRequestMethod);
            }
            List<String> list2 = headerFields.get("p-ikgx");
            if (list2 != null && !list2.isEmpty()) {
                String str = list2.get(0);
                if (!TextUtils.isEmpty(str)) {
                    headerParams.operatorType = str;
                }
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
        return headerParams;
    }

    private static void savePageReset(Context context, String str) {
        DefaultShared.putString(context, "key_p_rset_v5.0.5", str);
    }

    public static String getPageReset(Context context) {
        return DefaultShared.getString(context, "key_p_rset_v5.0.5", "0");
    }

    private static String getGwAuth(String str, String str2) {
        try {
            String[] strArrSplit = str.split(l.b);
            for (int i = 0; i < strArrSplit.length; i++) {
                if (strArrSplit[i].contains(str2)) {
                    return strArrSplit[i].split("=")[1];
                }
            }
            return "";
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }
}
