package com.kwad.components.offline.api.core.adInnerEc.pay;

/* JADX INFO: loaded from: classes3.dex */
public interface IHostPayResultListener {
    void onPayCancel();

    void onPayFailure(String str);

    void onPaySuccess();

    void onPayUnknown();
}
