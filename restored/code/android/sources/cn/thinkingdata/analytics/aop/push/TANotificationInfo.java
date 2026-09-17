package cn.thinkingdata.analytics.aop.push;

import com.alipay.sdk.m.c0.d;
import com.baidu.mobads.sdk.api.IAdInterListener;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TANotificationInfo {
    String content;
    long time;
    String title;

    TANotificationInfo(String str, String str2, long j) {
        this.title = str;
        this.content = str2;
        this.time = j;
    }

    public static TANotificationInfo fromJson(String str) {
        try {
            JSONObject jSONObject = new JSONObject(str);
            return new TANotificationInfo(jSONObject.optString(d.w), jSONObject.optString(IAdInterListener.AdProdType.PRODUCT_CONTENT), jSONObject.optLong("time"));
        } catch (JSONException unused) {
            return null;
        }
    }

    public String getContent() {
        return this.content;
    }

    public long getTime() {
        return this.time;
    }

    public String getTitle() {
        return this.title;
    }

    public void setContent(String str) {
        this.content = str;
    }

    public void setTime(long j) {
        this.time = j;
    }

    public void setTitle(String str) {
        this.title = str;
    }

    public String toJson() {
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(d.w, this.title);
            jSONObject.put(IAdInterListener.AdProdType.PRODUCT_CONTENT, this.content);
            jSONObject.put("time", this.time);
            return jSONObject.toString();
        } catch (JSONException unused) {
            return null;
        }
    }
}
