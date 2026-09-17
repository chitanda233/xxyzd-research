package com.czhj.volley;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
public final class Header {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f2316a;
    private final String b;

    public Header(String str, String str2) {
        this.f2316a = str;
        this.b = str2;
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }
        Header header = (Header) obj;
        return TextUtils.equals(this.f2316a, header.f2316a) && TextUtils.equals(this.b, header.b);
    }

    public final String getName() {
        return this.f2316a;
    }

    public final String getValue() {
        return this.b;
    }

    public int hashCode() {
        return (this.f2316a.hashCode() * 31) + this.b.hashCode();
    }

    public String toString() {
        return "Header[name=" + this.f2316a + ",value=" + this.b + "]";
    }
}
