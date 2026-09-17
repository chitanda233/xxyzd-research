package com.baidu.oauth.sdkbqt.result;

import com.baidu.oauth.sdkbqt.a.e;

/* JADX INFO: loaded from: classes.dex */
public class BdOauthResult extends OauthResult implements e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f593a;
    private String b;

    public String getCode() {
        return this.f593a;
    }

    public void setCode(String str) {
        this.f593a = str;
    }

    public String getState() {
        return this.b;
    }

    public void setState(String str) {
        this.b = str;
    }

    public String toString() {
        return "BdOauthResult: , code=" + this.f593a + ", state = " + this.b + ", isDegrade = " + this.isDegrade + ", isVisibleAuth = " + this.isVisibleAuth + ", isInstallBdApp = " + this.isInstallBdApp + ", isPassNewVersion = " + this.isPassNewVersion + ", retCode = " + getResultCode() + ", retMsg = " + getResultMsg() + ", retSubCode = " + this.resultSubCode + ", retSubMsg = " + this.resultSubMsg + ", appVersion = " + this.appVersion + ", passSdkVersion = " + this.passSdkVersion + ", allowLaunchAuthApp = " + this.allowLaunchAuthApp + ", loginStateBeforeAuth = " + this.loginStateBeforeAuth + ", loginStateAfterAuth = " + this.loginStateAfterAuth;
    }
}
