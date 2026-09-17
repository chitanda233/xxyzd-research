package com.kwad.sdk.collector;

import com.kwad.sdk.utils.r;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    public static String dk(String str) {
        try {
            return new String(com.kwad.sdk.core.a.c.LY().encode(r.o(y.X(new File(str)))));
        } catch (IOException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return null;
        }
    }
}
