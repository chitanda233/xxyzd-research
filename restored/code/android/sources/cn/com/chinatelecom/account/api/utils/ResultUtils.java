package cn.com.chinatelecom.account.api.utils;

import com.alipay.sdk.m.y.o;
import com.sigmob.sdk.archives.tar.e;
import kotlin.jvm.internal.ByteCompanionObject;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ResultUtils {
    public static final int CODE_CLOSE_PAGE = 80200;
    public static final int CODE_ENCRYPT_EXCEPTION = 80107;
    public static final int CODE_EXTERNAL_PARAM_EMPTY = 80500;
    public static final int CODE_FACE_NOT_EMPOWER = 80306;
    public static final int CODE_IFAA_AUTH_FAIL = 80303;
    public static final int CODE_IFAA_CANCEL = 80412;
    public static final int CODE_IFAA_PREFIX = 80400;
    public static final int CODE_IFAA_PRE_FAIL = 80454;
    public static final int CODE_INIT_DNS_FAIL = 80011;
    public static final int CODE_INIT_ERROR = 80103;
    public static final int CODE_IO_EXCEPTION = 80007;
    public static final int CODE_LOGIN_EXCEPTION = 80101;
    public static final int CODE_LOGIN_RESULT_EMPTY = 80100;
    public static final int CODE_MOBILE_NET_DISABLE = 80004;
    private static final int CODE_NETWORK_DISABLE = 80003;
    public static final int CODE_OTHER_WAY = 80201;
    public static final int CODE_PRELOGIN_EXCEPTION = 80102;
    public static final int CODE_REQUEST_EXCEPTION = 80001;
    public static final int CODE_RESPONSE_CODE_ERROR = 80002;
    public static final int CODE_SOCKET_TIMEOUT_EXCEPTION = 80005;
    public static final int CODE_SUCCESS = 0;
    public static final int CODE_SWITCH_EXCEPTION = 80801;
    public static final int CODE_SWITCH_TIMEOUT = 80800;
    public static final int CODE_TIMEOUT_EXCEPTION = 80000;
    public static final int CODE_TYPE_NOT_ENTER = 80305;
    public static final int CODE_TYPE_NOT_SUPPORT = 80455;
    public static final int CODE_UNKNOWN_HOST_EXCEPTION = 80006;
    public static final int CODE_YZ_PRE_FAIL = 80301;
    public static final String MSG_EXTERNAL_PARAM_EMPTY = "传入参数为空";
    public static final String MSG_TYPE_NOT_SUPPORT = "Biometric authentication is not currently supported";
    public static final byte[] MSG_TIMEOUT_EXCEPTION = {-30, -91, -67, -20, -69, -120, -30, -68, -113, -20, -99, -68};
    public static final byte[] MSG_REQUEST_EXCEPTION = {-30, -91, -67, -20, -69, -120, -19, -73, -101, -19, -79, -106, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_RESPONSE_CODE_ERROR = {-17, -103, -121, -17, -80, -98, -19, -86, -117, -29, -98, -109, -30, -91, -91};
    public static final byte[] MSG_NETWORK_DISABLE = {-20, -99, -86, -19, -73, -101, -19, -79, -106, -30, -75, -108, -20, -124, -81};
    public static final byte[] MSG_MOBILE_NET_DISABLE = {-19, -83, -79, -17, ByteCompanionObject.MIN_VALUE, -94, -19, -73, -101, -19, -79, -106, -20, -106, -96, -17, -74, -118, -17, -102, -91};
    public static final byte[] MSG_SOCKET_TIMEOUT_EXCEPTION = {89, 101, 105, 97, 111, 126, -30, -68, -113, -20, -99, -68, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_UNKNOWN_HOST_EXCEPTION = {-17, -107, -107, -17, -102, -121, -30, -83, -87, -20, -108, -102, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_IO_EXCEPTION = {67, 69, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_LOGIN_RESULT_EMPTY = {-19, -109, -79, -17, -73, -97, -19, -79, -103, -20, -108, -106, -18, -78, -80, -19, -93, -80};
    public static final byte[] MSG_LOGIN_EXCEPTION = {-19, -109, -79, -17, -73, -97, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_PRELOGIN_EXCEPTION = {-29, -88, -114, -19, -109, -79, -17, -73, -97, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_INIT_ERROR = {-30, -91, -67, -17, -113, -126, -17, -126, -105, -17, -83, -127, -17, -122, -100, 89, 78, 65};
    public static final byte[] MSG_CLOSE_PAGE = {-19, -98, -94, -20, -126, -67, -17, -113, -71, -29, -99, -89, -19, -97, -122, -29, -105, -88};
    public static final byte[] MSG_OTHER_WAY = {-17, -113, -68, -18, -79, -100, -19, -109, -79, -17, -73, -97, -20, -100, -77, -17, -74, -123};
    public static final byte[] MSG_SWITCH_TIMEOUT = {93, 67, e.P, 67, -17, -126, -115, -20, -121, -88, -30, -68, -113, -20, -99, -68};
    public static final byte[] MSG_SWITCH_EXCEPTION = {93, 67, e.P, 67, -17, -126, -115, -20, -121, -88, -17, -74, -120, -17, -78, -78};
    public static final byte[] MSG_INIT_DNS_FAIL = {-17, -125, -121, -19, -73, -92, -17, -107, -107, -17, -102, -121, -30, -83, -87, -20, -108, -102, -17, -82, -69, -30, -66, -81};
    public static final byte[] MSG_CODE_ENCRYPT_EXCEPTION = {111, 100, 105, e.R, 115, 122, 126, 42, 111, 114, 105, 111, 122, 126, 99, 101, 100};

    public static JSONObject getNetworkDisable() {
        return toJsonResult(80003, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_NETWORK_DISABLE));
    }

    public static String getRequestException() {
        return toResult(80001, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_REQUEST_EXCEPTION));
    }

    public static JSONObject getRequestExceptionJson() {
        return toJsonResult(80001, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_REQUEST_EXCEPTION), null);
    }

    public static JSONObject getTimeoutException() {
        return toJsonResult(80000, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_TIMEOUT_EXCEPTION));
    }

    public static JSONObject getMobileNetDisable() {
        return toJsonResult(80004, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_MOBILE_NET_DISABLE));
    }

    public static JSONObject getInitError() {
        return toJsonResult(CODE_INIT_ERROR, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_INIT_ERROR));
    }

    public static JSONObject getParamEmpty() {
        return toJsonResult(CODE_EXTERNAL_PARAM_EMPTY, MSG_EXTERNAL_PARAM_EMPTY);
    }

    public static String getSwitchTimeout() {
        return toResult(CODE_SWITCH_TIMEOUT, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_SWITCH_TIMEOUT));
    }

    public static String getClosePage() {
        return toResult(CODE_CLOSE_PAGE, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_CLOSE_PAGE));
    }

    public static String getLoginResultEmpty() {
        return toResult(CODE_LOGIN_RESULT_EMPTY, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_LOGIN_RESULT_EMPTY));
    }

    public static String getLoginException() {
        return toResult(CODE_LOGIN_EXCEPTION, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_LOGIN_EXCEPTION));
    }

    public static String getPreloginException() {
        return toResult(CODE_PRELOGIN_EXCEPTION, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_PRELOGIN_EXCEPTION));
    }

    public static JSONObject getPreloginExceptionJson() {
        return toJsonResult(CODE_PRELOGIN_EXCEPTION, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_PRELOGIN_EXCEPTION));
    }

    public static String getOtherWay() {
        return toResult(CODE_OTHER_WAY, cn.com.chinatelecom.account.api.encrypt.Xor.de(MSG_OTHER_WAY));
    }

    public static String toResult(int i, String str) {
        return toResult(i, str, null);
    }

    public static String toResult(int i, String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(o.c, i);
            jSONObject.put("msg", str);
            if (str2 != null && !str2.isEmpty()) {
                jSONObject.put("reqId", str2);
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject.toString();
    }

    public static JSONObject toJsonResult(int i, String str) {
        return toJsonResult(i, str, null);
    }

    public static JSONObject toJsonResult(int i, String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(o.c, i);
            jSONObject.put("msg", str);
            if (str2 != null && !str2.isEmpty()) {
                jSONObject.put("reqId", str2);
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }
}
