package com.kwad.framework.filedownloader.services;

import android.app.Service;
import android.content.Intent;
import android.os.Build;
import android.os.IBinder;
import android.webkit.WebView;
import com.kwad.sdk.api.core.KsAdSdkDynamicImpl;
import com.kwad.sdk.api.proxy.app.FileDownloadService;
import com.kwad.sdk.utils.ba;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
@KsAdSdkDynamicImpl(FileDownloadService.class)
public class FileDownloadServiceProxy extends com.kwad.sdk.l.a {
    private static final String TAG = "filedownloader";
    public Service context;
    private i handler;

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public IBinder onBind(Service service, Intent intent) {
        return this.handler.DA();
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public void onCreate(Service service) {
        if (service == null) {
            return;
        }
        this.context = service;
        com.kwad.framework.filedownloader.f.c.aX(service.getApplicationContext());
        try {
            com.kwad.framework.filedownloader.f.f.cU(com.kwad.framework.filedownloader.f.e.DL().aDu);
            com.kwad.framework.filedownloader.f.f.af(com.kwad.framework.filedownloader.f.e.DL().aDv);
        } catch (IllegalAccessException e) {
            e.printStackTrace();
        }
        g gVar = new g();
        if (com.kwad.framework.filedownloader.f.e.DL().aDx) {
            this.handler = new e(new WeakReference(this), gVar);
        } else {
            this.handler = new d(new WeakReference(this), gVar);
        }
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public void onDestroy(Service service) {
        this.handler.onDestroy();
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public int onStartCommand(Service service, Intent intent, int i, int i2) {
        this.handler.Dz();
        return 2;
    }

    @KsAdSdkDynamicImpl(FileDownloadService.SharedMainProcessService.class)
    public static class SharedMainProcessServiceProxy extends FileDownloadServiceProxy {
        @Override // com.kwad.framework.filedownloader.services.FileDownloadServiceProxy, com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
        public void onCreate(Service service) {
            super.onCreate(service);
        }
    }

    @KsAdSdkDynamicImpl(FileDownloadService.SeparateProcessService.class)
    public static class SeparateProcessServiceProxy extends FileDownloadServiceProxy {
        @Override // com.kwad.framework.filedownloader.services.FileDownloadServiceProxy, com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
        public void onCreate(Service service) {
            if (Build.VERSION.SDK_INT >= 28) {
                try {
                    WebView.setDataDirectorySuffix(ba.getProcessName(service.getApplicationContext()));
                } catch (Exception unused) {
                }
            }
            super.onCreate(service);
        }
    }

    public static void register() {
        com.kwad.sdk.service.c.putComponentProxy(FileDownloadService.SeparateProcessService.class, SeparateProcessServiceProxy.class);
        com.kwad.sdk.service.c.putComponentProxy(FileDownloadService.SharedMainProcessService.class, SharedMainProcessServiceProxy.class);
    }
}
