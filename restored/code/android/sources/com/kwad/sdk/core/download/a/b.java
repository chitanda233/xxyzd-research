package com.kwad.sdk.core.download.a;

import android.content.Context;
import android.content.Intent;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.C;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class b {

    public interface a {
        void aJ(int i);

        void onError(Throwable th);

        void onPreStart();

        void onStart();

        void onSuccess();

        void qF();

        boolean qG();
    }

    /* JADX INFO: renamed from: com.kwad.sdk.core.download.a.b$b, reason: collision with other inner class name */
    public static class C0509b implements a {
        @Override // com.kwad.sdk.core.download.a.b.a
        public final void aJ(int i) {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public void onError(Throwable th) {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public final void onPreStart() {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public void onStart() {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public void onSuccess() {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public final void qF() {
        }

        @Override // com.kwad.sdk.core.download.a.b.a
        public final boolean qG() {
            return false;
        }
    }

    public static int I(Context context, String str) {
        return a(context, str, new C0509b());
    }

    public static int a(Context context, String str, a aVar) {
        if (TextUtils.isEmpty(str) || context == null) {
            if (TextUtils.isEmpty(str)) {
                aVar.aJ(3);
            } else if (context == null) {
                aVar.aJ(4);
            }
            return 0;
        }
        try {
            aVar.onPreStart();
            com.kwad.sdk.core.d.c.d("DeepLinkUtil", "handleDeepLink: " + str);
            Uri uri = Uri.parse(str);
            h hVar = (h) ServiceProvider.get(h.class);
            int iCO = hVar != null ? hVar.cO(uri.getScheme()) : -1;
            Intent intent = new Intent();
            intent.setAction("android.intent.action.VIEW");
            intent.setData(uri);
            com.kwad.sdk.core.d.c.d("DeepLinkUtil", "handleDeepLink: configFlags: " + iCO);
            if (iCO > 0) {
                intent.setFlags(iCO);
            } else {
                intent.setFlags(C.ENCODING_PCM_MU_LAW);
            }
            List<ResolveInfo> listQueryIntentActivities = context.getPackageManager().queryIntentActivities(intent, 65536);
            if (listQueryIntentActivities != null && listQueryIntentActivities.size() > 0) {
                aVar.onStart();
                context.startActivity(intent);
                aVar.onSuccess();
                return 1;
            }
            aVar.qF();
            if (!aVar.qG()) {
                return 0;
            }
            aVar.onStart();
            context.startActivity(intent);
            aVar.onSuccess();
            return 1;
        } catch (Throwable th) {
            aVar.onError(th);
            return -1;
        }
    }
}
