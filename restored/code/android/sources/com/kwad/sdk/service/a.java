package com.kwad.sdk.service;

import android.app.Service;
import android.content.Intent;
import android.os.Handler;
import android.os.Message;
import android.text.TextUtils;
import com.kwad.sdk.DownloadTask;
import com.kwad.sdk.api.proxy.app.DownloadService;
import java.lang.ref.WeakReference;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.l.a {
    private com.kwad.sdk.c bnP;
    private Service bnR;
    private final Map<String, Integer> bnQ = new ConcurrentHashMap();
    private final HandlerC0535a bnS = new HandlerC0535a(this);

    private void h(Intent intent) {
        if (intent == null) {
            return;
        }
        try {
            int intExtra = intent.getIntExtra("download_service_type_tag", 0);
            String stringExtra = intent.getStringExtra("download_service_id_tag");
            DownloadTask.DownloadRequest downloadRequest = (DownloadTask.DownloadRequest) intent.getSerializableExtra("download_service_args_tag");
            Integer num = TextUtils.isEmpty(stringExtra) ? null : this.bnQ.get(stringExtra);
            int iIntValue = num != null ? num.intValue() : 0;
            if (intExtra == 1) {
                this.bnQ.put(stringExtra, Integer.valueOf(this.bnP.a(downloadRequest, (com.kwad.sdk.a) null)));
                return;
            }
            if (intExtra == 2) {
                this.bnP.pause(iIntValue);
                return;
            }
            if (intExtra == 3) {
                this.bnP.resume(iIntValue);
                return;
            }
            if (intExtra != 4) {
                return;
            }
            if (iIntValue != 0) {
                this.bnP.cancel(iIntValue);
                return;
            }
            String stringExtra2 = intent.getStringExtra("download_service_path");
            if (stringExtra2 != null) {
                com.kwad.sdk.c.cJ(stringExtra2);
            }
        } catch (Exception unused) {
        }
    }

    public static void register() {
        c.putComponentProxy(DownloadService.class, a.class);
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public void onCreate(Service service) {
        if (service == null) {
            return;
        }
        this.bnR = service;
        this.bnP = com.kwad.sdk.c.EK();
        this.bnS.sendEmptyMessageDelayed(1, 30000L);
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public int onStartCommand(Service service, Intent intent, int i, int i2) {
        h(intent);
        return super.onStartCommand(service, intent, i, i2);
    }

    /* JADX INFO: renamed from: com.kwad.sdk.service.a$a, reason: collision with other inner class name */
    static class HandlerC0535a extends Handler {
        final WeakReference<a> bnT;

        public HandlerC0535a(a aVar) {
            this.bnT = new WeakReference<>(aVar);
        }

        @Override // android.os.Handler
        public final void handleMessage(Message message) {
            a aVar = this.bnT.get();
            if (aVar != null && message.what == 1) {
                if (aVar.bnP != null && aVar.bnP.EQ()) {
                    aVar.bnR.stopSelf();
                } else {
                    sendEmptyMessageDelayed(1, 30000L);
                }
            }
        }
    }
}
