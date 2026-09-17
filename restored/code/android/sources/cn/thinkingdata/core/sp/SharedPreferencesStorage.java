package cn.thinkingdata.core.sp;

import android.content.SharedPreferences;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public abstract class SharedPreferencesStorage<T> {
    protected T data;
    private final Future<SharedPreferences> loadStoredPreferences;
    protected final String storageKey;

    public SharedPreferencesStorage(Future<SharedPreferences> future, String str) {
        this.loadStoredPreferences = future;
        this.storageKey = str;
    }

    private SharedPreferences.Editor getEditor() {
        SharedPreferences sharedPreferences;
        try {
            sharedPreferences = this.loadStoredPreferences.get();
        } catch (InterruptedException e) {
            e.printStackTrace();
            sharedPreferences = null;
        } catch (ExecutionException e2) {
            e2.printStackTrace();
            sharedPreferences = null;
        }
        if (sharedPreferences != null) {
            return sharedPreferences.edit();
        }
        return null;
    }

    protected T create() {
        return null;
    }

    public T get() {
        SharedPreferences sharedPreferences;
        if (this.data == null) {
            synchronized (this.loadStoredPreferences) {
                try {
                    try {
                        sharedPreferences = this.loadStoredPreferences.get();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                        sharedPreferences = null;
                    }
                } catch (ExecutionException e2) {
                    e2.printStackTrace();
                    sharedPreferences = null;
                }
                if (sharedPreferences != null) {
                    load(sharedPreferences);
                }
            }
        }
        return this.data;
    }

    protected void load(SharedPreferences sharedPreferences) {
        T t = (T) sharedPreferences.getString(this.storageKey, null);
        if (t == null) {
            put(create());
        } else {
            this.data = t;
        }
    }

    public void put(T t) {
        this.data = t;
        synchronized (this.loadStoredPreferences) {
            SharedPreferences.Editor editor = getEditor();
            if (editor != null) {
                save(editor, this.data);
            }
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    protected void save(SharedPreferences.Editor editor, T t) {
        editor.putString(this.storageKey, (String) t);
        editor.apply();
    }
}
