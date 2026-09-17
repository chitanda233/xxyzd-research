package cn.thinkingdata.core;

import java.util.TimeZone;
import javax.net.ssl.SSLSocketFactory;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDSettings {
    public String appId;
    public TimeZone defaultTimeZone;
    public boolean enableAutoCalibrated;
    public boolean enableAutoPush;
    public boolean enableLog;
    public String encryptKey;
    public int encryptVersion;
    public String instanceName;
    public TDMode mode;
    public JSONObject rccFetchParams;
    public String serverUrl;
    public SSLSocketFactory sslSocketFactory;

    public enum TDMode {
        NORMAL,
        DEBUG,
        DEBUG_ONLY
    }
}
