package com.kwad.framework.filedownloader.a;

import java.io.InputStream;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public interface b {
    Map<String, List<String>> Ca();

    Map<String, List<String>> Cb();

    void Cc();

    void addHeader(String str, String str2);

    String bU(String str);

    void execute();

    InputStream getInputStream();

    int getResponseCode();
}
