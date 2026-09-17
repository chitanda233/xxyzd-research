package com.kwad.library.solder.a;

import android.content.Context;
import com.kwad.library.solder.lib.b.c;
import com.kwad.library.solder.lib.c.b;
import com.kwad.library.solder.lib.i;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static com.kwad.library.b.a n(Context context, String str) {
        com.kwad.library.solder.lib.a.a aVarP = i.Ec().p(context, str);
        if (aVarP != null && aVarP.isLoaded() && (aVarP instanceof com.kwad.library.b.a)) {
            return (com.kwad.library.b.a) aVarP;
        }
        return null;
    }

    public static void a(Context context, b bVar, com.kwad.library.solder.lib.ext.b.c cVar) {
        i.Ec().a(context, new c(bVar), cVar);
    }

    public static void a(Context context, b bVar, com.kwad.library.solder.lib.ext.b.a aVar) {
        i.Ec().a(context, new com.kwad.library.solder.lib.b.a(bVar), aVar);
    }

    public static void o(Context context, String str) {
        i.Ec().o(context, str);
    }
}
