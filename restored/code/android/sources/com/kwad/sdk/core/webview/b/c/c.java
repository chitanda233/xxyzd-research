package com.kwad.sdk.core.webview.b.c;

import com.baidu.mobads.sdk.internal.an;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static final List<String> bcW;

    static {
        ArrayList arrayList = new ArrayList();
        bcW = arrayList;
        arrayList.add("application/x-javascript");
        arrayList.add("image/jpeg");
        arrayList.add("image/tiff");
        arrayList.add("text/css");
        arrayList.add("text/html");
        arrayList.add("image/gif");
        arrayList.add("image/png");
        arrayList.add("application/javascript");
        arrayList.add("video/mp4");
        arrayList.add("audio/mpeg");
        arrayList.add(an.d);
        arrayList.add("image/webp");
        arrayList.add("image/apng");
        arrayList.add("image/svg+xml");
        arrayList.add("application/octet-stream");
    }

    public static boolean fS(String str) {
        return bcW.contains(str);
    }
}
