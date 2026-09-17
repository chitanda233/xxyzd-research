package com.kwad.components.offline.api.adInnerEc.login;

import java.io.Serializable;

/* JADX INFO: loaded from: classes3.dex */
public class InnerEcLoginResponse implements Serializable {
    private static final long serialVersionUID = 5382742918171282206L;
    protected String accessToken;
    protected String code;
    protected String command;
    protected int errorCode;
    protected String errorMsg;
    protected boolean hasLoggedIn;
    protected boolean newUser;
    protected String state;

    public void setCode(String str) {
        this.code = str;
    }

    public void setAccessToken(String str) {
        this.accessToken = str;
    }

    public int getErrorCode() {
        return this.errorCode;
    }

    public String getErrorMsg() {
        return this.errorMsg;
    }

    public String getCommand() {
        return this.command;
    }

    public void setErrorCode(int i) {
        this.errorCode = i;
    }

    public void setErrorMsg(String str) {
        this.errorMsg = str;
    }

    public void setCommand(String str) {
        this.command = str;
    }

    public void setState(String str) {
        this.state = str;
    }

    public void setHasLoggedIn(boolean z) {
        this.hasLoggedIn = z;
    }

    public boolean isHasLoggedIn() {
        return this.hasLoggedIn;
    }

    public String getCode() {
        return this.code;
    }

    public String getState() {
        return this.state;
    }

    public String getAccessToken() {
        return this.accessToken;
    }

    public boolean isSuccess() {
        return 1 == getErrorCode();
    }

    public boolean isNewUser() {
        return this.newUser;
    }

    public void setNewUser(boolean z) {
        this.newUser = z;
    }
}
