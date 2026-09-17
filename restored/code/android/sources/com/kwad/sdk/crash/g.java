package com.kwad.sdk.crash;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.sdk.utils.AbiUtil;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private static final AtomicBoolean bek = new AtomicBoolean(false);

    public interface a {
        void Qh();

        void rb();
    }

    public static void a(c cVar, a aVar) {
        String str;
        String str2;
        String str3;
        AtomicBoolean atomicBoolean = bek;
        if (atomicBoolean.get()) {
            aVar.Qh();
            return;
        }
        if (cVar.sdkVersion.compareTo(cVar.bdM) < 0) {
            com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "sdkVersion:" + cVar.sdkVersion + "*supportAppVersion:" + cVar.bdM);
            aVar.rb();
            return;
        }
        if (!TextUtils.isEmpty(cVar.bdN) && cVar.sdkVersion.compareTo(cVar.bdN) >= 0) {
            com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "sdkVersion:" + cVar.sdkVersion + "*maxVersionExclude:" + cVar.bdN);
            aVar.rb();
            return;
        }
        Context context = cVar.context;
        atomicBoolean.set(true);
        if (AbiUtil.isArm64(context)) {
            str = cVar.bdQ;
            if (TextUtils.isEmpty(str)) {
                str = "https://p1-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/so/exception/202406211433/ks_so-exceptionArm64v8aRelease-3.3.67-e8fbb3a5f8-666.apk";
            }
            str2 = cVar.bdS;
            str3 = "exception-v8a";
        } else {
            str = cVar.bdR;
            if (TextUtils.isEmpty(str)) {
                str = "https://p1-lm.adkwai.com/udata/pkg/KS-Android-KSAdSDk/so/exception/202406211433/ks_so-exceptionArmeabiv7aRelease-3.3.67-e8fbb3a5f8-666.apk";
            }
            str2 = cVar.bdT;
            str3 = "exception-v7a";
        }
        com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "url:" + str + " pluginName:" + str3 + " md5:" + str2);
        com.kwad.library.solder.lib.c.b bVar = new com.kwad.library.solder.lib.c.b();
        bVar.aFu = com.kwad.sdk.core.network.idc.a.My().eO(str);
        bVar.enable = true;
        bVar.aFt = str3;
        bVar.version = cVar.bdL;
        bVar.aFw = str2;
        bVar.aFx = false;
        a(context, bVar, aVar);
    }

    private static void a(Context context, com.kwad.library.solder.lib.c.b bVar, final a aVar) {
        com.kwad.library.solder.a.a.a(context, bVar, new com.kwad.library.solder.lib.ext.b.c() { // from class: com.kwad.sdk.crash.g.1
            @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
            public final /* synthetic */ void a(com.kwad.library.solder.lib.a.e eVar, com.kwad.library.solder.lib.a.a aVar2) {
                Ay();
            }

            @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
            public final /* bridge */ /* synthetic */ void a(com.kwad.library.solder.lib.a.e eVar, PluginError pluginError) {
                a(pluginError);
            }

            private void Ay() {
                com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "onPostLoad");
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.Qh();
                }
            }

            private void a(PluginError pluginError) {
                com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "onFail thread=" + Thread.currentThread().getName() + "\n" + pluginError);
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.rb();
                }
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void f(com.kwad.library.solder.lib.b.c cVar) {
                super.f(cVar);
                com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "onCanceled thread=" + Thread.currentThread().getName());
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.library.solder.lib.ext.b.C0493b, com.kwad.library.solder.lib.ext.b
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void d(com.kwad.library.solder.lib.b.c cVar) {
                super.d(cVar);
                com.kwad.sdk.core.d.c.d("AnrAndNativeExceptionSoLoadHelper", "onPostUpdate thread=" + Thread.currentThread().getName());
            }
        });
    }
}
