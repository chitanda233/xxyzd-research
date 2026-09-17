package cn.com.chinatelecom.account.api.net;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ResponseInfo {
    public static final String DM_CARD = "2";
    public static final String DM_ID6 = "1";
    public static final int FAILED = -1;
    public static final int SUCCESS = 0;
    public JSONObject result;
    public int errorCode = -1;
    public String gwAuth = "";
    public boolean retryPreLogin = false;
    public String retryPreLoginType = "1";
}
