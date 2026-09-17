package com.samsung.android.sdk.sinstallreferrer.api;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.content.pm.ResolveInfo;
import android.content.pm.ServiceInfo;
import android.os.Bundle;
import android.os.IBinder;
import android.os.RemoteException;
import com.samsung.android.sdk.sinstallreferrer.commons.InstallReferrerCommons;
import com.sec.android.app.samsungapps.lib.IInstallReferrerAgentAPI;
import com.sec.android.app.samsungapps.lib.IInstallReferrerAgentResultCallback;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
class a extends InstallReferrerClient {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3102a = 0;
    private final Context b;
    private IInstallReferrerAgentAPI c;
    private ServiceConnection d;

    private final class b implements ServiceConnection {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final InstallReferrerStateListener f3103a;
        private ReferrerDetails b;

        /* JADX INFO: renamed from: com.samsung.android.sdk.sinstallreferrer.api.a$b$a, reason: collision with other inner class name */
        class BinderC0554a extends IInstallReferrerAgentResultCallback.a {
            BinderC0554a() {
            }

            @Override // com.sec.android.app.samsungapps.lib.IInstallReferrerAgentResultCallback
            public void a(Bundle bundle) throws RemoteException {
                b.this.b = new ReferrerDetails(bundle);
                b.this.f3103a.onInstallReferrerSetupFinished(0);
            }
        }

        private b(InstallReferrerStateListener installReferrerStateListener) {
            if (installReferrerStateListener == null) {
                throw new RuntimeException("Please specify a listener to know when setup is done.");
            }
            this.f3103a = installReferrerStateListener;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public ReferrerDetails a() {
            return this.b;
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            InstallReferrerCommons.logVerbose("GSReferrerClient", "Install Referrer service connected.");
            a.this.c = IInstallReferrerAgentAPI.a.a(iBinder);
            a.this.f3102a = 2;
            if (a.this.c == null) {
                InstallReferrerCommons.logWarn("GSReferrerClient", "Install referrer service initialization fail");
                a.this.f3102a = 0;
                this.f3103a.onInstallReferrerServiceDisconnected();
                return;
            }
            try {
                Bundle bundle = new Bundle();
                bundle.putString("guid", a.this.b.getPackageName());
                a.this.c.a(bundle, new BinderC0554a());
            } catch (RemoteException unused) {
                InstallReferrerCommons.logWarn("GSReferrerClient", "RemoteException getting install referrer information");
                a.this.f3102a = 0;
                this.f3103a.onInstallReferrerServiceDisconnected();
            }
        }

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
            InstallReferrerCommons.logWarn("GSReferrerClient", "Install Referrer service disconnected.");
            a.this.c = null;
            a.this.f3102a = 0;
            this.f3103a.onInstallReferrerServiceDisconnected();
        }
    }

    public a(Context context) {
        this.b = context.getApplicationContext();
    }

    private boolean a() {
        Bundle bundle;
        try {
            ApplicationInfo applicationInfo = this.b.getPackageManager().getApplicationInfo("com.sec.android.app.samsungapps", 128);
            return (applicationInfo == null || (bundle = applicationInfo.metaData) == null || bundle.getInt("com.sec.android.app.samsungapps.InstallReferrerAgent.version") < 1) ? false : true;
        } catch (PackageManager.NameNotFoundException unused) {
        }
    }

    @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerClient
    public void endConnection() {
        this.f3102a = 3;
        if (this.d != null) {
            InstallReferrerCommons.logVerbose("GSReferrerClient", "Unbinding from service.");
            this.b.unbindService(this.d);
            this.d = null;
        }
        this.c = null;
    }

    @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerClient
    public ReferrerDetails getInstallReferrer() {
        if (isReady()) {
            return ((b) this.d).a();
        }
        throw new IllegalStateException("Service not connected. Please start a connection before using the service.");
    }

    @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerClient
    public boolean isReady() {
        return (this.f3102a != 2 || this.c == null || this.d == null) ? false : true;
    }

    @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerClient
    public void startConnection(InstallReferrerStateListener installReferrerStateListener) {
        String str;
        ServiceInfo serviceInfo;
        if (isReady()) {
            InstallReferrerCommons.logVerbose("GSReferrerClient", "Service connection is valid. No need to re-initialize.");
            installReferrerStateListener.onInstallReferrerSetupFinished(0);
            return;
        }
        int i = this.f3102a;
        if (i == 1) {
            str = "Client is already in the process of connecting to the service.";
        } else {
            if (i != 3) {
                InstallReferrerCommons.logVerbose("GSReferrerClient", "Starting install referrer service setup.");
                Intent intent = new Intent("com.sec.android.app.samsungapps.api.InstallReferrerAgent");
                intent.setPackage("com.sec.android.app.samsungapps");
                List<ResolveInfo> listQueryIntentServices = this.b.getPackageManager().queryIntentServices(intent, 0);
                if (listQueryIntentServices == null || listQueryIntentServices.isEmpty() || (serviceInfo = listQueryIntentServices.get(0).serviceInfo) == null) {
                    this.f3102a = 0;
                    InstallReferrerCommons.logVerbose("GSReferrerClient", "Install Referrer service unavailable on device.");
                    installReferrerStateListener.onInstallReferrerSetupFinished(2);
                    return;
                }
                String str2 = serviceInfo.packageName;
                String str3 = serviceInfo.name;
                if (!"com.sec.android.app.samsungapps".equals(str2) || str3 == null || !a()) {
                    InstallReferrerCommons.logWarn("GSReferrerClient", "GalaxyStore missing or incompatible.");
                    this.f3102a = 0;
                    installReferrerStateListener.onInstallReferrerSetupFinished(2);
                    return;
                }
                Intent intent2 = new Intent(intent);
                b bVar = new b(installReferrerStateListener);
                this.d = bVar;
                if (this.b.bindService(intent2, bVar, 1)) {
                    InstallReferrerCommons.logVerbose("GSReferrerClient", "Service was bonded successfully.");
                    return;
                }
                InstallReferrerCommons.logWarn("GSReferrerClient", "Connection to service is blocked.");
                this.f3102a = 0;
                installReferrerStateListener.onInstallReferrerSetupFinished(1);
                return;
            }
            str = "Client was already closed and can't be reused. Please create another instance.";
        }
        InstallReferrerCommons.logWarn("GSReferrerClient", str);
        installReferrerStateListener.onInstallReferrerSetupFinished(3);
    }
}
