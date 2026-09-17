package com.sigmob.sdk.downloader;

import java.io.IOException;
import java.net.ProtocolException;

/* JADX INFO: loaded from: classes3.dex */
public class j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3462a = 10;
    static final int b = 307;
    static final int c = 308;

    public static String a(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected, int responseCode) throws IOException {
        String strC = connected.c("Location");
        if (strC != null) {
            return strC;
        }
        throw new ProtocolException("Response code is " + responseCode + " but can't find Location field");
    }

    public static boolean a(int code) {
        return code == 301 || code == 302 || code == 303 || code == 300 || code == 307 || code == 308;
    }
}
