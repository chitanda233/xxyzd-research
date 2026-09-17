package com.sigmob.sdk.mraid2;

import android.webkit.ConsoleMessage;
import android.webkit.JsResult;
import com.sigmob.sdk.base.models.BaseAdUnit;

/* JADX INFO: loaded from: classes3.dex */
public interface f {
    void a();

    void a(int red, int green, int blue, int alpha);

    void a(BaseAdUnit adUnit);

    boolean a(ConsoleMessage consoleMessage);

    boolean a(String message, JsResult result);

    void b();

    void c();

    void d();
}
