package com.unity3d.adaptiveperformance.samsung;

import android.app.Activity;
import android.util.Log;
import com.samsung.android.gamesdk.GameSDKManager;
import com.unity3d.player.UnityPlayer;
import java.util.Scanner;

/* JADX INFO: loaded from: classes4.dex */
public class GameLoadBooster {
    private static GameSDKManager manager;
    private static Boolean startupBoostEnabled;

    static {
        enableBoost();
    }

    public static boolean enableBoost() {
        boolean cpuBoostMode;
        boolean gpuBoostMode;
        try {
            if (!isStartupBoostEnabled()) {
                return false;
            }
            if (manager == null) {
                manager = new GameSDKManager();
            }
            if (manager.getVersion().equals("3.5")) {
                cpuBoostMode = manager.setCpuBoostMode(1);
                gpuBoostMode = manager.setGpuBoostMode(1);
            } else {
                cpuBoostMode = false;
                gpuBoostMode = false;
            }
            if (cpuBoostMode && gpuBoostMode) {
                Log.v("Unity", "Enabled boost mode on launch");
            }
            return cpuBoostMode && gpuBoostMode;
        } catch (Exception unused) {
            return false;
        }
    }

    private static boolean isStartupBoostEnabled() {
        if (startupBoostEnabled == null) {
            startupBoostEnabled = Boolean.valueOf(checkStartupBoostEnabled());
        }
        return startupBoostEnabled.booleanValue();
    }

    private static boolean checkStartupBoostEnabled() throws Throwable {
        boolean z = true;
        Scanner scanner = null;
        try {
            Activity activity = UnityPlayer.currentActivity;
            if (activity == null) {
                return true;
            }
            Scanner scanner2 = new Scanner(activity.getAssets().open("bin/Data/boot.config"));
            try {
                scanner2.useDelimiter("\n");
                while (scanner2.hasNext()) {
                    if ("adaptive-performance-samsung-boost-launch=0".equals(scanner2.next())) {
                        z = false;
                        break;
                    }
                }
                scanner2.close();
                return z;
            } catch (Exception unused) {
                scanner = scanner2;
            } catch (Throwable th) {
                th = th;
                scanner = scanner2;
                if (scanner != null) {
                    scanner.close();
                }
                throw th;
            }
        } catch (Exception unused2) {
        } catch (Throwable th2) {
            th = th2;
        }
        if (scanner != null) {
            scanner.close();
        }
        return true;
    }
}
