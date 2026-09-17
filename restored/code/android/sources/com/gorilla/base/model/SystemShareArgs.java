package com.gorilla.base.model;

import android.text.TextUtils;
import com.alipay.sdk.m.c0.d;
import com.bytedance.pangle.provider.ContentProviderManager;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class SystemShareArgs {
    private final String chooserTitle;
    private final String filePath;
    private final String mimeType;
    private final int shareType;
    private final String title;
    private final String uri;
    private final String url;

    private SystemShareArgs(int i, String str, String str2, String str3, String str4, String str5, String str6) {
        this.shareType = i;
        this.title = str;
        this.chooserTitle = str2;
        this.url = str3;
        this.filePath = str4;
        this.uri = str5;
        this.mimeType = str6;
    }

    public static SystemShareArgs fromJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return null;
        }
        return new SystemShareArgs(jSONObject.optInt("shareType", 0), sanitize(jSONObject.optString(d.w)), sanitize(jSONObject.optString("chooserTitle")), sanitize(jSONObject.optString("url")), sanitize(jSONObject.optString("filePath")), sanitize(jSONObject.optString(ContentProviderManager.PROVIDER_URI)), sanitize(jSONObject.optString("mimeType")));
    }

    public int getShareType() {
        return this.shareType;
    }

    public String getTitle() {
        return this.title;
    }

    public String getChooserTitle(String str) {
        return !TextUtils.isEmpty(this.chooserTitle) ? this.chooserTitle : str;
    }

    public String getUrl() {
        return this.url;
    }

    public String getMimeType() {
        return this.mimeType;
    }

    public String getFileLocation() {
        if (!TextUtils.isEmpty(this.filePath)) {
            return this.filePath;
        }
        return this.uri;
    }

    private static String sanitize(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        return str;
    }
}
