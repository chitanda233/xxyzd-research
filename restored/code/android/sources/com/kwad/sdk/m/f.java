package com.kwad.sdk.m;

import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import java.util.Random;
import java.util.concurrent.TimeUnit;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    public static final String TAG = "Ranger_f";

    public static void dA(final String str) {
        i.schedule(new bi() { // from class: com.kwad.sdk.m.f.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                String str2 = str;
                if (TextUtils.isEmpty(str2)) {
                    com.kwad.sdk.core.d.c.w(f.TAG, "config is empty");
                    return;
                }
                d dVarHw = f.hw(str2);
                if (dVarHw != null) {
                    com.kwad.sdk.core.d.c.d(f.TAG, "config:" + dVarHw.toJson().toString());
                }
                if (dVarHw == null || dVarHw.TT()) {
                    return;
                }
                f.d(dVarHw);
            }
        }, 0L, TimeUnit.SECONDS);
    }

    public static d hw(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            d dVar = new d();
            dVar.parseJson(jSONObject);
            return dVar;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.w(TAG, e);
            return null;
        }
    }

    public static void d(d dVar) {
        if (new Random().nextFloat() >= dVar.sampleRate) {
            com.kwad.sdk.core.d.c.d(TAG, "config.sampleRate：" + dVar.sampleRate + " return");
            return;
        }
        if (dVar.TU()) {
            a(dVar);
        }
        if (dVar.TV()) {
            e(dVar);
        }
        if (dVar.TW()) {
            f(dVar);
        }
    }

    private static void a(d dVar) {
        try {
            a.a(dVar);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.e(TAG, Log.getStackTraceString(th));
        }
    }

    private static void e(d dVar) {
        c.TR().c(dVar);
    }

    private static void f(final d dVar) {
        GlobalThreadPools.Og().execute(new Runnable() { // from class: com.kwad.sdk.m.f.2
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    b.TM().b(dVar);
                    b.TM().TO();
                    b.TM().clearAll();
                    b.TM().start();
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.e(f.TAG, Log.getStackTraceString(e));
                }
            }
        });
    }
}
