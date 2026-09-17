package com.kwad.sdk.core.response.helper;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bg;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.nio.charset.Charset;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    private static volatile f aXD;
    private String aXE = NL();

    private f() {
    }

    public static f NJ() {
        if (aXD == null) {
            synchronized (f.class) {
                if (aXD == null) {
                    aXD = new f();
                }
            }
        }
        return aXD;
    }

    public final String NK() {
        return this.aXE;
    }

    public final void fl(String str) {
        if (br.isEquals(this.aXE, str)) {
            return;
        }
        this.aXE = str;
        fm(str);
    }

    private static String NL() {
        try {
            return y.a(new File(bg.ei(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext())), Charset.forName("UTF-8"));
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static void fm(String str) {
        try {
            y.a(new File(bg.ei(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext())), str, Charset.forName("UTF-8"), false);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }
}
