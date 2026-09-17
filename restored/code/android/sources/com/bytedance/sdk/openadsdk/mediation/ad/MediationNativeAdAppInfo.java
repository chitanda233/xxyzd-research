package com.bytedance.sdk.openadsdk.mediation.ad;

import com.byazt.zqa.c;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
@c(c = {0, 80, 81, 82, 83, 686, 1991})
public class MediationNativeAdAppInfo {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f1919a;
    private String c;
    private String da;
    private Map<String, Object> i;
    private Map<String, String> n;
    private String sp;
    private String tt;
    private String uj;
    private long ve;
    private String x;

    public String getAppName() {
        return this.c;
    }

    public void setAppName(String str) {
        this.c = str;
    }

    public String getAuthorName() {
        return this.tt;
    }

    public void setAuthorName(String str) {
        this.tt = str;
    }

    public long getPackageSizeBytes() {
        return this.ve;
    }

    public void setPackageSizeBytes(long j) {
        this.ve = j;
    }

    public String getPermissionsUrl() {
        return this.uj;
    }

    public void setPermissionsUrl(String str) {
        this.uj = str;
    }

    public Map<String, String> getPermissionsMap() {
        return this.n;
    }

    public void setPermissionsMap(Map<String, String> map) {
        this.n = map;
    }

    public String getPrivacyAgreement() {
        return this.f1919a;
    }

    public void setPrivacyAgreement(String str) {
        this.f1919a = str;
    }

    public String getVersionName() {
        return this.sp;
    }

    public void setVersionName(String str) {
        this.sp = str;
    }

    public String getFunctionDescUrl() {
        return this.x;
    }

    public void setFunctionDescUrl(String str) {
        this.x = str;
    }

    public Map<String, Object> getAppInfoExtra() {
        return this.i;
    }

    public void setAppInfoExtra(Map<String, Object> map) {
        this.i = map;
    }

    public String getRegUrl() {
        return this.da;
    }

    public void setRegUrl(String str) {
        this.da = str;
    }
}
