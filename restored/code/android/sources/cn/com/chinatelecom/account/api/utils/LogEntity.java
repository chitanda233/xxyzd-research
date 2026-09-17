package cn.com.chinatelecom.account.api.utils;

import android.os.Build;
import android.os.SystemClock;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.ClientUtils;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.thinkingdata.core.utils.TimeUtil;
import com.alipay.sdk.m.w.a;
import com.alipay.sdk.m.y.l;
import com.kuaishou.weapon.p0.t;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class LogEntity {
    private long endTime;
    private String reqId;
    private int result;
    private int retryCount;
    private long switchTime;
    private long totalTime = -1;
    private StringBuffer exception = new StringBuffer();
    private String tag = "";
    private String deviceId = "";
    private String params = "";
    private String apiFlag = "";
    private String msg = "";
    private String version = Constants.LOG_UPLOAD_VERSION;
    private long startTime = SystemClock.uptimeMillis();
    private String time = getLogTime(System.currentTimeMillis());
    private String appId = CtAuth.mAppId;
    private String netStatus = "";
    private String brand = Build.BRAND;
    private String model = Build.MODEL;
    private String os = Constants.LOG_OS;
    private String osVersion = Build.VERSION.RELEASE;
    private String sdkVersion = ClientUtils.getSdkVersion();
    private String operatorType = "0";

    public LogEntity(String str) {
        this.reqId = str;
    }

    public static String getLogTime(long j) {
        try {
            return new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA).format(new Date(j));
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }

    public String getReqId() {
        return this.reqId;
    }

    public LogEntity setTag(String str) {
        this.tag = str;
        return this;
    }

    public LogEntity setDeviceId(String str) {
        this.deviceId = str;
        return this;
    }

    public LogEntity setSwitchTime(long j) {
        if (j > 0) {
            this.switchTime = j;
        }
        return this;
    }

    public LogEntity setNetState(String str) {
        this.netStatus = str;
        return this;
    }

    public LogEntity setApiFlag(String str) {
        this.apiFlag = str;
        return this;
    }

    public LogEntity setParams(String str) {
        this.params = str;
        return this;
    }

    public LogEntity setResult(int i) {
        this.result = i;
        return this;
    }

    public LogEntity setMsg(String str) {
        this.msg = str;
        return this;
    }

    public LogEntity setOperatorType(String str) {
        if (!TextUtils.isEmpty(str)) {
            this.operatorType = str;
        }
        return this;
    }

    public LogEntity setRetryCount(int i) {
        this.retryCount = i;
        return this;
    }

    public LogEntity putException(String str) {
        if (!TextUtils.isEmpty(str)) {
            this.exception.append(str).append(l.b);
        }
        return this;
    }

    public void finish() {
        long jUptimeMillis = SystemClock.uptimeMillis();
        this.endTime = jUptimeMillis;
        if (this.totalTime == -1) {
            this.totalTime = jUptimeMillis - this.startTime;
        }
    }

    public void setStartTime() {
        this.startTime = SystemClock.uptimeMillis();
    }

    public void setTotalTime(long j) {
        this.totalTime = j;
    }

    public String toString() {
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(t.c, this.version);
            jSONObject.put("t", this.time);
            jSONObject.put("tag", this.tag);
            jSONObject.put("ai", this.appId);
            jSONObject.put("di", this.deviceId);
            jSONObject.put("ns", this.netStatus);
            jSONObject.put("br", this.brand);
            jSONObject.put("ml", this.model);
            jSONObject.put("os", this.os);
            jSONObject.put("ov", this.osVersion);
            jSONObject.put(a.v, this.sdkVersion);
            jSONObject.put("ri", this.reqId);
            jSONObject.put("api", this.apiFlag);
            jSONObject.put(t.b, this.params);
            jSONObject.put("rt", this.result);
            jSONObject.put("msg", this.msg);
            jSONObject.put("st", this.switchTime);
            jSONObject.put("tt", this.totalTime);
            jSONObject.put("ot", this.operatorType);
            jSONObject.put("rec", this.retryCount);
            jSONObject.put("ep", this.exception.toString());
            return jSONObject.toString();
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }
}
