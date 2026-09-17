package com.kwad.components.offline.api.core.adInnerEc;

/* JADX INFO: loaded from: classes3.dex */
public interface IHostLoginStatusListener {
    void onLoginFailure(String str);

    void onLoginSuccess();

    void onLogout();
}
