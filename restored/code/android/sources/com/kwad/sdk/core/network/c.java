package com.kwad.sdk.core.network;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public int aSW = -1;
    public Exception aSX;
    public String aSY;
    public int code;

    public final boolean Mq() {
        return this.code == 200;
    }

    public final String toString() {
        return "BaseResponse{code=" + this.code + ", rawCode=" + this.aSW + ", rawException=" + this.aSX + ", body='" + this.aSY + "'}";
    }
}
