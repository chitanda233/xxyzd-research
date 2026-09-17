package com.chuanglan.shanyan_sdk.tool;

import android.text.TextUtils;
import com.chuanglan.shanyan_sdk.Q;

/* JADX INFO: loaded from: classes2.dex */
public class ConfigPrivacyBean {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2010a;
    private String b;
    private int c;
    private String d;
    private String e;

    public ConfigPrivacyBean(String str, String str2, int i, String str3) {
        this.c = 0;
        this.d = "、";
        this.e = "";
        Q.a("UIShanYanLogger", "privacy info", str, str2);
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str2)) {
            throw new IllegalStateException("name,  url, is null");
        }
        this.f2010a = str;
        this.b = str2;
        this.c = i;
        this.d = str3;
        this.e = str;
    }

    public int getColor() {
        return this.c;
    }

    public String getMidStr() {
        return this.d;
    }

    public String getName() {
        return this.f2010a;
    }

    public String getTitle() {
        return this.e;
    }

    public String getUrl() {
        return this.b;
    }

    public void setColor(int i) {
        this.c = i;
    }

    public void setMidStr(String str) {
        this.d = str;
    }

    public void setName(String str) {
        this.f2010a = str;
    }

    public void setTitle(String str) {
        this.e = str;
    }

    public void setUrl(String str) {
        this.b = str;
    }

    public ConfigPrivacyBean(String str, String str2, int i) {
        this.c = 0;
        this.d = "、";
        this.e = "";
        if (!TextUtils.isEmpty(str) && !TextUtils.isEmpty(str2)) {
            this.f2010a = str;
            this.b = str2;
            this.c = i;
            this.e = str;
            return;
        }
        throw new IllegalStateException("name,  url,  is null");
    }

    public ConfigPrivacyBean(String str, String str2) {
        this.c = 0;
        this.d = "、";
        this.e = "";
        if (!TextUtils.isEmpty(str) && !TextUtils.isEmpty(str2)) {
            this.f2010a = str;
            this.b = str2;
            this.e = str;
            return;
        }
        throw new IllegalStateException("name,  url,  is null");
    }
}
