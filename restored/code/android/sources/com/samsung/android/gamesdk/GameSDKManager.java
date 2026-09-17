package com.samsung.android.gamesdk;

import android.os.IBinder;
import android.os.RemoteException;
import android.os.ServiceManager;
import android.util.Log;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;

/* JADX INFO: loaded from: classes3.dex */
public class GameSDKManager {
    private static final int DEFAULT_REFRESH_RATE = 60;
    private static final float GameSDK2_0 = 2.0f;
    private static final float GameSDK3_0 = 3.0f;
    private static final float GameSDK3_1 = 3.1f;
    private static final float GameSDK3_2 = 3.2f;
    private static final float GameSDK3_3 = 3.3f;
    private static final float GameSDK3_4 = 3.4f;
    private static final double INVALID_DOUBLE = -999.0d;
    private static final int INVALID_INT = -999;
    private static final String TAG = "GameSDKManager";
    private IGameSDKService mService;
    private Listener mListener = null;
    private float mServiceVersion = -1.0f;
    private final int[] mEmptyIntArrary = new int[0];

    public interface Listener {
        void onHighTempWarning(int i);

        void onRefreshRateChanged();

        void onReleasedByTimeout();

        void onReleasedCpuBoost();

        void onReleasedGpuBoost();
    }

    public GameSDKManager() {
        this.mService = null;
        IBinder service = ServiceManager.getService("gamesdk");
        if (service != null) {
            this.mService = IGameSDKService.Stub.asInterface(service);
            updateServiceVersion();
        }
    }

    public boolean initialize() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        try {
            return iGameSDKService.initGameSDK();
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public boolean initialize(String str) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        try {
            if (this.mServiceVersion <= GameSDK3_1) {
                Log.w(TAG, "initialize(String version) API is not supported this GameSDK Version");
                return false;
            }
            return iGameSDKService.initGameSDKWithVersion(str);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public void finalize(String str) {
        if (str == null) {
            Log.w(TAG, "packagename is null");
            return;
        }
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return;
        }
        try {
            iGameSDKService.finalGameSDK(str);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    public static boolean isAvailable() {
        return ServiceManager.getService("gamesdk") != null;
    }

    public String getVersion() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return "0";
        }
        try {
            return iGameSDKService.getVersion();
        } catch (RemoteException e) {
            e.printStackTrace();
            return "0";
        }
    }

    public int getTempLevel() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getTempLevel();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public int getSkinTempLevel() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getSkinTempLevel();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public int getCPULevelMax() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        if (this.mServiceVersion < GameSDK3_0) {
            Log.w(TAG, "getCPULevelMax() API is not supported this GameSDK Version");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getCPULevelMax();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public int getGPULevelMax() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        if (this.mServiceVersion < GameSDK3_0) {
            Log.w(TAG, "getGPULevelMax() API is not supported this GameSDK Version");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getGPULevelMax();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public double getHighPrecisionSkinTempLevel() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_DOUBLE;
        }
        if (this.mServiceVersion < 2.0f) {
            Log.w(TAG, "getHighPrecisionSkinTempLevel() API is not supported this GameSDK Version");
            return INVALID_DOUBLE;
        }
        try {
            return iGameSDKService.getHighPrecisionSkinTempLevel();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_DOUBLE;
        }
    }

    public boolean setLevelWithScene(String str, int i, int i2) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        try {
            if (this.mServiceVersion == GameSDK3_2 && i == 0) {
                i = 1;
            }
            return iGameSDKService.setLevelWithScene(str, i, i2);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public boolean setListener(Listener listener) {
        this.mListener = listener;
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            return false;
        }
        if (listener == null) {
            try {
                return iGameSDKService.setGameSDKListener((IGameSDKListener) null);
            } catch (RemoteException e) {
                e.printStackTrace();
                return false;
            }
        }
        try {
            return this.mService.setGameSDKListener(new IGameSDKListener.Stub() { // from class: com.samsung.android.gamesdk.GameSDKManager.1
                public void onHighTempWarning(int i) {
                    GameSDKManager.this.mListener.onHighTempWarning(i);
                }

                public void onRefreshRateChanged() {
                    GameSDKManager.this.mListener.onRefreshRateChanged();
                }

                public void onReleasedByTimeout() {
                    GameSDKManager.this.mListener.onReleasedByTimeout();
                }

                public void onReleasedCpuBoost() {
                    GameSDKManager.this.mListener.onReleasedCpuBoost();
                }

                public void onReleasedGpuBoost() {
                    GameSDKManager.this.mListener.onReleasedGpuBoost();
                }
            });
        } catch (RemoteException e2) {
            e2.printStackTrace();
            return false;
        }
    }

    public int getCpuJTLevel() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getCpuJTLevel();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public int getGpuJTLevel() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getGpuJTLevel();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public double getGpuFrameTime() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_DOUBLE;
        }
        try {
            double gpuFrameTime = iGameSDKService.getGpuFrameTime();
            if (INVALID_DOUBLE != gpuFrameTime) {
                return gpuFrameTime;
            }
            double frameworkFPS = this.mService.getFrameworkFPS();
            double gpuUsage = getGpuUsage();
            if (gpuUsage != INVALID_DOUBLE) {
                return Math.round((gpuUsage * (1000.0d / frameworkFPS)) * 100.0d) / 100.0d;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return INVALID_DOUBLE;
    }

    private double getGpuUsage() {
        try {
            byte[] allBytes = Files.readAllBytes(Paths.get("/sys/kernel/gpu/gpu_busy", new String[0]));
            if (allBytes != null && allBytes.length != 0) {
                String str = new String(allBytes, StandardCharsets.UTF_8);
                int iIndexOf = str.indexOf("%");
                if (iIndexOf > 0) {
                    return Double.parseDouble(str.substring(0, iIndexOf)) * 0.009999999776482582d;
                }
                return Double.parseDouble(str) * 0.009999999776482582d;
            }
            return INVALID_DOUBLE;
        } catch (Exception e) {
            e.printStackTrace();
            return INVALID_DOUBLE;
        }
    }

    public boolean setDisableTMLevel(int i) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "setDisableTMLevel() API is not supported this GameSDK Version");
            return false;
        }
        try {
            return iGameSDKService.setDisableTMLevel(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public int setFreqLevels(int i, int i2) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        float f = this.mServiceVersion;
        if (f < GameSDK3_1) {
            Log.w(TAG, "setFreqLevels() API is not supported this GameSDK Version");
            return INVALID_INT;
        }
        if (f == GameSDK3_2 && i == 0) {
            i = 1;
        }
        try {
            return iGameSDKService.setFreqLevels(i, i2);
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public boolean setCpuBoostMode(int i) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        if (this.mServiceVersion < GameSDK3_4) {
            Log.w(TAG, "setCpuBoostMode() API is not supported this GameSDK Version");
            return false;
        }
        try {
            return iGameSDKService.setCpuBoostMode(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public boolean setGpuBoostMode(int i) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        if (this.mServiceVersion < GameSDK3_4) {
            Log.w(TAG, "setGpuBoostMode() API is not supported this GameSDK Version");
            return false;
        }
        try {
            return iGameSDKService.setGpuBoostMode(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public int getClusterInfo() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return INVALID_INT;
        }
        if (this.mServiceVersion < GameSDK3_4) {
            Log.w(TAG, "getClusterInfo() API is not supported this GameSDK Version");
            return INVALID_INT;
        }
        try {
            return iGameSDKService.getClusterInfo();
        } catch (RemoteException e) {
            e.printStackTrace();
            return INVALID_INT;
        }
    }

    public boolean isGameSDKVariableRefreshRateSupported() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return false;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "isGameSDKVariableRefreshRateSupported() API is not supported this GameSDK Version");
            return false;
        }
        try {
            return iGameSDKService.isGameSDKVrrSupported();
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    public int[] getSupportedRefreshRates() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return this.mEmptyIntArrary;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "getSupportedRefreshRates() API is not supported this GameSDK Version");
            return this.mEmptyIntArrary;
        }
        try {
            return iGameSDKService.getSupportedRefreshRates();
        } catch (RemoteException e) {
            e.printStackTrace();
            return this.mEmptyIntArrary;
        }
    }

    public void setRefreshRate(int i) {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "setRefreshRate() API is not supported this GameSDK Version");
            return;
        }
        try {
            iGameSDKService.setRefreshRate(i);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    public void resetRefreshRate() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "resetRefreshRate() API is not supported this GameSDK Version");
            return;
        }
        try {
            iGameSDKService.resetRefreshRate();
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    public int getCurrentRefreshRate() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return 60;
        }
        if (this.mServiceVersion < GameSDK3_1) {
            Log.w(TAG, "getCurrentRefreshRate() API is not supported this GameSDK Version");
            return 60;
        }
        try {
            return iGameSDKService.getCurrentRefreshRate();
        } catch (RemoteException e) {
            e.printStackTrace();
            return 60;
        }
    }

    private void updateServiceVersion() {
        IGameSDKService iGameSDKService = this.mService;
        if (iGameSDKService == null) {
            Log.w(TAG, "gamesdk system service is not available");
            return;
        }
        try {
            this.mServiceVersion = Float.parseFloat(iGameSDKService.getVersion());
            Log.w(TAG, "updateServiceVersion() : " + this.mServiceVersion);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }
}
