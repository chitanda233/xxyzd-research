package com.baidu.passbqt.http;

import com.baidu.passbqt.NoProguard;

/* JADX INFO: loaded from: classes.dex */
public class HttpErrorException extends Exception implements NoProguard {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f619a;

    public HttpErrorException() {
    }

    public HttpErrorException(int i, String str) {
        super(str);
        this.f619a = i;
    }
}
