package com.kwad.sdk.collector.b;

import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.os.IBinder;
import android.os.Message;
import android.os.Messenger;
import android.os.Process;
import android.os.RemoteException;
import android.webkit.WebView;
import com.kwad.sdk.api.proxy.app.ServiceProxyRemote;
import com.kwad.sdk.collector.AppStatusRules;
import com.kwad.sdk.collector.d;
import com.kwad.sdk.collector.model.b;
import com.kwad.sdk.service.c;
import com.kwad.sdk.utils.SystemUtil;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.ba;
import com.kwad.sdk.utils.h;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.l.a {
    private static AtomicBoolean aJn = new AtomicBoolean(false);
    public static volatile Message aJo;
    private HandlerC0498a aJl = new HandlerC0498a(0);
    private Messenger aJm = new Messenger(this.aJl);

    public static void register() {
        try {
            c.putComponentProxy(Class.forName("com.kwad.sdk.api.proxy.app.ServiceProxyRemote"), a.class);
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public void onCreate(Service service) {
        super.onCreate(service);
        if (Build.VERSION.SDK_INT >= 28) {
            try {
                WebView.setDataDirectorySuffix(ba.getProcessName(service.getApplicationContext()));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.d("RemoteService", "WebView has already been initialized " + e.getMessage());
            }
        }
        com.kwad.sdk.core.d.c.d("RemoteService", "onCreate processName:" + ba.getProcessName(service));
        if (!SystemUtil.isInMainProcess(service)) {
            d.a(service, new d.a() { // from class: com.kwad.sdk.collector.b.a.1
                @Override // com.kwad.sdk.collector.d.a
                public final void onLoaded() {
                    com.kwad.sdk.core.d.c.d("RemoteService", "onLoaded");
                    a.aJn.set(true);
                    if (a.aJo != null) {
                        a.this.aJl.handleMessage(a.aJo);
                        a.aJo = null;
                    }
                }

                @Override // com.kwad.sdk.collector.d.a
                public final void di(String str) {
                    com.kwad.sdk.core.d.c.e("RemoteService", "onLoadError: " + str);
                    a.aJn.set(false);
                }
            });
        } else {
            aJn.set(true);
        }
        this.aJl.a(service);
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public void onDestroy(Service service) {
        super.onDestroy(service);
        com.kwad.sdk.core.d.c.d("RemoteService", "onDestroy");
        this.aJl.a(null);
        if (bI(service)) {
            com.kwad.sdk.core.d.c.d("RemoteService", "goto kill myself");
            Process.killProcess(Process.myPid());
        }
    }

    public static AtomicBoolean It() {
        return aJn;
    }

    public static void a(Context context, ServiceConnection serviceConnection) {
        com.kwad.sdk.core.d.c.d("RemoteService", "bindASService");
        context.bindService(new Intent(context, (Class<?>) ServiceProxyRemote.class), serviceConnection, 1);
    }

    public static void b(Context context, ServiceConnection serviceConnection) {
        com.kwad.sdk.core.d.c.d("RemoteService", "unbindASService");
        try {
            context.unbindService(serviceConnection);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    @Override // com.kwad.sdk.l.a, com.kwad.sdk.api.proxy.IServiceProxy
    public IBinder onBind(Service service, Intent intent) {
        return this.aJm.getBinder();
    }

    /* JADX INFO: renamed from: com.kwad.sdk.collector.b.a$a, reason: collision with other inner class name */
    static class HandlerC0498a extends Handler {
        private WeakReference<Service> aJq;

        private HandlerC0498a() {
        }

        /* synthetic */ HandlerC0498a(byte b) {
            this();
        }

        public final void a(Service service) {
            if (service != null) {
                this.aJq = new WeakReference<>(service);
            } else {
                this.aJq = null;
            }
        }

        @Override // android.os.Handler
        public final void handleMessage(Message message) {
            super.handleMessage(message);
            com.kwad.sdk.core.d.c.d("RemoteService", "handleMessage");
            WeakReference<Service> weakReference = this.aJq;
            Service service = weakReference != null ? weakReference.get() : null;
            if (service == null) {
                return;
            }
            if (!a.It().get()) {
                com.kwad.sdk.core.d.c.d("RemoteService", "save buffered message");
                a.aJo = Message.obtain(message);
                return;
            }
            final Messenger messenger = message.replyTo;
            int i = message.what;
            com.kwad.sdk.core.d.c.d("RemoteService", "handleMessage what: " + i);
            if (i != 100) {
                return;
            }
            final Bundle bundle = new Bundle();
            h.a(service, new h.b() { // from class: com.kwad.sdk.collector.b.a.a.1
                @Override // com.kwad.sdk.utils.h.b
                public final void D(List<b> list) {
                    com.kwad.sdk.core.d.c.d("RemoteService", "RemoteService: onAppStatusResult list: " + list);
                    if (list != null && !list.isEmpty()) {
                        com.kwad.sdk.core.d.c.d("RemoteService", "RemoteService: onAppStatusResult: " + list.size());
                        JSONArray jSONArrayV = h.a.V(list);
                        String string = jSONArrayV != null ? jSONArrayV.toString() : null;
                        com.kwad.sdk.core.d.c.d("RemoteService", "resultJson :" + string);
                        if (string != null) {
                            AppStatusRules appStatusRulesUo = h.Uo();
                            ArrayList<AppStatusRules.Strategy> allStrategy = appStatusRulesUo != null ? appStatusRulesUo.getAllStrategy() : null;
                            String string2 = allStrategy != null ? ac.Y(allStrategy).toString() : null;
                            bundle.putString("resultJson", string);
                            bundle.putString("allStrategyJson", string2);
                        }
                    }
                    try {
                        Message messageObtain = Message.obtain();
                        messageObtain.what = 101;
                        messageObtain.setData(bundle);
                        messenger.send(messageObtain);
                    } catch (RemoteException unused) {
                    }
                    if (list == null || list.isEmpty()) {
                        return;
                    }
                    Iterator<b> it = list.iterator();
                    while (it.hasNext()) {
                        it.next().destroy();
                    }
                }
            });
        }
    }

    private static boolean bI(Context context) {
        String processName = ba.getProcessName(context);
        return (processName == null || context.getPackageName().equals(processName)) ? false : true;
    }
}
