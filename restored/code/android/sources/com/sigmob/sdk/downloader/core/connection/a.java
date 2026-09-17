package com.sigmob.sdk.downloader.core.connection;

import java.io.IOException;
import java.io.InputStream;
import java.net.ProtocolException;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public interface a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3398a = 0;

    /* JADX INFO: renamed from: com.sigmob.sdk.downloader.core.connection.a$a, reason: collision with other inner class name */
    public interface InterfaceC0560a {
        String c(String name);

        int d() throws IOException;

        InputStream e() throws IOException;

        Map<String, List<String>> f();

        String g();
    }

    public interface b {
        a a(String url) throws IOException;
    }

    InterfaceC0560a a() throws IOException;

    void a(String name, String value);

    boolean a(String method) throws ProtocolException;

    String b(String key);

    void b();

    Map<String, List<String>> c();
}
