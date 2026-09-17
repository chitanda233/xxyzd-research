package com.kwad.sdk.mobileid;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private String biV;
    private String errorReason;
    private boolean success;

    public d(boolean z, String str) {
        this.success = z;
        this.errorReason = str;
    }

    public final boolean isSuccess() {
        return this.success;
    }

    public final String Sv() {
        return this.errorReason;
    }

    public final String Sw() {
        return this.biV;
    }

    public final void gZ(String str) {
        this.biV = str;
    }

    public final String toString() {
        return "UaidErrorReason{success=" + this.success + ", errorReason='" + this.errorReason + "', extraErrorMsg='" + this.biV + "'}";
    }
}
