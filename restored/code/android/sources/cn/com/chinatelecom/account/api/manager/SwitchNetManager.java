package cn.com.chinatelecom.account.api.manager;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkInfo;
import android.net.NetworkRequest;
import android.os.Handler;
import android.os.Looper;
import cn.com.chinatelecom.account.api.CtAuth;
import java.net.InetAddress;
import kotlin.UByte;

/* JADX INFO: loaded from: classes.dex */
public class SwitchNetManager implements ISwitchNet {
    public static final int DELAY_CHECK = 2500;
    private static final int RT_ERROR = -1;
    private static final int RT_OK = 0;
    private static final int RT_TIMEOUT = -2;
    private static final String TAG = "SwitchNetManager";
    private static Handler handler = new Handler(Looper.getMainLooper());
    private Context context;
    private boolean isCallback;
    private ConnectivityManager.NetworkCallback myNetCallback;

    public SwitchNetManager(Context context) {
        this.context = context;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void setCallback() {
        this.isCallback = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized boolean isCallback() {
        return this.isCallback;
    }

    private void checkTimeOut(final SwitchCalllBack switchCalllBack) {
        handler.postDelayed(new Runnable() { // from class: cn.com.chinatelecom.account.api.manager.SwitchNetManager.1
            @Override // java.lang.Runnable
            public void run() {
                if (SwitchNetManager.this.isCallback() || switchCalllBack == null) {
                    return;
                }
                SwitchNetManager.this.setCallback();
                switchCalllBack.onSwitchTimeout();
            }
        }, 2500L);
    }

    @Override // cn.com.chinatelecom.account.api.manager.ISwitchNet
    public void switchToMobileNetV5(final SwitchCalllBack switchCalllBack) {
        final long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            checkTimeOut(switchCalllBack);
            ConnectivityManager connectivityManager = (ConnectivityManager) this.context.getSystemService("connectivity");
            NetworkRequest.Builder builder = new NetworkRequest.Builder();
            builder.addCapability(12);
            builder.addTransportType(0);
            NetworkRequest networkRequestBuild = builder.build();
            ConnectivityManager.NetworkCallback networkCallback = new ConnectivityManager.NetworkCallback() { // from class: cn.com.chinatelecom.account.api.manager.SwitchNetManager.2
                @Override // android.net.ConnectivityManager.NetworkCallback
                public void onAvailable(Network network) {
                    if (SwitchNetManager.this.isCallback() || switchCalllBack == null) {
                        return;
                    }
                    SwitchNetManager.this.setCallback();
                    switchCalllBack.onSwitchSuccess(network, System.currentTimeMillis() - jCurrentTimeMillis);
                }
            };
            this.myNetCallback = networkCallback;
            connectivityManager.requestNetwork(networkRequestBuild, networkCallback);
        } catch (Throwable unused) {
            if (isCallback() || switchCalllBack == null) {
                return;
            }
            switchCalllBack.onSwitchError(System.currentTimeMillis() - jCurrentTimeMillis);
        }
    }

    public void unregisterNetwork() {
        try {
            if (this.myNetCallback != null) {
                ((ConnectivityManager) this.context.getSystemService("connectivity")).unregisterNetworkCallback(this.myNetCallback);
                this.myNetCallback = null;
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    @Override // cn.com.chinatelecom.account.api.manager.ISwitchNet
    public void switchToMobileNetV4(final SwitchCalllBack switchCalllBack, final String str) {
        new ThreadPoolManager().executeTask(new WorkTask() { // from class: cn.com.chinatelecom.account.api.manager.SwitchNetManager.3
            @Override // cn.com.chinatelecom.account.api.manager.WorkTask
            public void runTask() {
                final long jCurrentTimeMillis = System.currentTimeMillis();
                int iSwitchToMobileNetV4 = SwitchNetManager.this.switchToMobileNetV4(str);
                if (iSwitchToMobileNetV4 == 0) {
                    switchCalllBack.onSwitchSuccess(null, System.currentTimeMillis() - jCurrentTimeMillis);
                } else if (iSwitchToMobileNetV4 == -1) {
                    SwitchNetManager.handler.post(new Runnable() { // from class: cn.com.chinatelecom.account.api.manager.SwitchNetManager.3.1
                        @Override // java.lang.Runnable
                        public void run() {
                            switchCalllBack.onSwitchError(System.currentTimeMillis() - jCurrentTimeMillis);
                        }
                    });
                } else {
                    SwitchNetManager.handler.post(new Runnable() { // from class: cn.com.chinatelecom.account.api.manager.SwitchNetManager.3.2
                        @Override // java.lang.Runnable
                        public void run() {
                            switchCalllBack.onSwitchTimeout();
                        }
                    });
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public int switchToMobileNetV4(String str) {
        try {
            Class<?> cls = Class.forName("android.net.ConnectivityManager");
            ConnectivityManager connectivityManager = (ConnectivityManager) this.context.getSystemService("connectivity");
            if (connectivityManager.getNetworkInfo(5).getState().compareTo(NetworkInfo.State.CONNECTED) != 0) {
                cls.getMethod("startUsingNetworkFeature", Integer.TYPE, String.class).invoke(connectivityManager, 0, "enableHIPRI");
                for (int i = 0; i < 5; i++) {
                    try {
                        if (connectivityManager.getNetworkInfo(5).getState().compareTo(NetworkInfo.State.CONNECTED) == 0) {
                            break;
                        }
                        Thread.sleep(500L);
                    } catch (Throwable th) {
                        CtAuth.warn(TAG, "STMN_V4", th);
                    }
                }
            }
            boolean zBooleanValue = ((Boolean) cls.getMethod("requestRouteToHost", Integer.TYPE, Integer.TYPE).invoke(connectivityManager, 5, Integer.valueOf(lookupHost(extractAddressFromUrl(str))))).booleanValue();
            CtAuth.info(TAG, "STMN_V4 ：" + zBooleanValue);
            return zBooleanValue ? 0 : -2;
        } catch (Throwable th2) {
            CtAuth.warn(TAG, "STMN_V4_T", th2);
            return -1;
        }
    }

    public static int lookupHost(String str) {
        try {
            byte[] address = InetAddress.getByName(str).getAddress();
            return (address[0] & UByte.MAX_VALUE) | ((address[3] & UByte.MAX_VALUE) << 24) | ((address[2] & UByte.MAX_VALUE) << 16) | ((address[1] & UByte.MAX_VALUE) << 8);
        } catch (Throwable th) {
            CtAuth.warn(TAG, "When InetAddress.getByName(),throws exception", th);
            return -1;
        }
    }

    public static String extractAddressFromUrl(String str) {
        int iIndexOf = str.indexOf("://");
        if (iIndexOf > 0) {
            str = str.substring(iIndexOf + 3);
        }
        int iIndexOf2 = str.indexOf(58);
        if (iIndexOf2 >= 0) {
            str = str.substring(0, iIndexOf2);
        }
        int iIndexOf3 = str.indexOf(47);
        if (iIndexOf3 >= 0) {
            str = str.substring(0, iIndexOf3);
        }
        int iIndexOf4 = str.indexOf(63);
        return iIndexOf4 >= 0 ? str.substring(0, iIndexOf4) : str;
    }
}
