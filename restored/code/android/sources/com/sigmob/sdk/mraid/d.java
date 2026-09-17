package com.sigmob.sdk.mraid;

import android.webkit.ConsoleMessage;
import android.webkit.JsResult;
import com.sigmob.windad.WindAdError;
import java.net.URI;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public interface d {
    void a();

    void a(int width, int height, int offsetX, int offsetY, b.a closePosition, boolean allowOffscreen);

    void a(final WindAdError error);

    void a(String event, Map<String, String> params);

    void a(URI uri);

    void a(URI uri, int interActionType, String ext);

    void a(URI uri, boolean shouldUseCustomClose) throws f;

    void a(boolean isVisible);

    void a(boolean allowOrientationChange, p forceOrientation) throws f;

    boolean a(ConsoleMessage consoleMessage);

    boolean a(String message, JsResult result);

    void b();

    void b(String event, Map<String, String> params);

    void b(boolean shouldUseCustomClose);

    void c();

    void d();

    void e();

    void f();

    void g();
}
