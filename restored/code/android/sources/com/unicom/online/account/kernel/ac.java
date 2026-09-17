package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import java.lang.reflect.Method;
import java.net.InetAddress;
import java.net.UnknownHostException;
import java.util.Objects;
import kotlin.UByte;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ac {
    public static void b(Context context, String str) {
        int i;
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService("connectivity");
            if (connectivityManager == null) {
                return;
            }
            NetworkInfo.State state = connectivityManager.getNetworkInfo(5).getState();
            Objects.toString(state);
            if (state.compareTo(NetworkInfo.State.CONNECTED) != 0 && state.compareTo(NetworkInfo.State.CONNECTING) != 0) {
                Method method = ConnectivityManager.class.getMethod("startUsingNetworkFeature", Integer.TYPE, String.class);
                method.setAccessible(true);
                int iIntValue = ((Integer) method.invoke(connectivityManager, 0, "enableHIPRI")).intValue();
                if (-1 == iIntValue || iIntValue == 0) {
                    return;
                }
                try {
                    byte[] address = InetAddress.getByName(str).getAddress();
                    i = (address[0] & UByte.MAX_VALUE) | ((address[3] & UByte.MAX_VALUE) << 24) | ((address[2] & UByte.MAX_VALUE) << 16) | ((address[1] & UByte.MAX_VALUE) << 8);
                } catch (UnknownHostException unused) {
                    i = -1;
                }
                if (-1 == i) {
                    return;
                }
                for (int i2 = 0; i2 < 5; i2++) {
                    try {
                        if (connectivityManager.getNetworkInfo(5).getState().compareTo(NetworkInfo.State.CONNECTED) == 0) {
                            break;
                        }
                        Thread.sleep(500L);
                    } catch (InterruptedException e) {
                        as.b(e);
                        return;
                    }
                }
                Class cls = Integer.TYPE;
                Method method2 = ConnectivityManager.class.getMethod("requestRouteToHost", cls, cls);
                method2.setAccessible(true);
                ((Boolean) method2.invoke(connectivityManager, 5, Integer.valueOf(i))).booleanValue();
            }
        } catch (Exception e2) {
            as.b(e2);
        }
    }
}
