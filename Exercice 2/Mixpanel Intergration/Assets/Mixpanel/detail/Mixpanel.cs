//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mixpanel.detail {

public class Mixpanel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Mixpanel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Mixpanel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Mixpanel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          MixpanelSDKPINVOKE.delete_Mixpanel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Mixpanel(string token, bool enable_log_queue, bool opt_out) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_0(token, enable_log_queue, opt_out), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Mixpanel(string token, bool enable_log_queue) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_1(token, enable_log_queue), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Mixpanel(string token) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_2(token), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Mixpanel(string token, string distinct_id, string storage_directory, bool enable_log_queue, bool opt_out) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_3(token, distinct_id, storage_directory, enable_log_queue, opt_out), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Mixpanel(string token, string distinct_id, string storage_directory, bool enable_log_queue) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_4(token, distinct_id, storage_directory, enable_log_queue), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Mixpanel(string token, string distinct_id, string storage_directory) : this(MixpanelSDKPINVOKE.new_Mixpanel__SWIG_5(token, distinct_id, storage_directory), true) {
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public void identify(string unique_id) {
    MixpanelSDKPINVOKE.Mixpanel_identify(swigCPtr, unique_id);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void alias(string alias) {
    MixpanelSDKPINVOKE.Mixpanel_alias(swigCPtr, alias);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void register_(string key, Value value) {
    MixpanelSDKPINVOKE.Mixpanel_register_(swigCPtr, key, Value.getCPtr(value));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void register_properties(Value properties) {
    MixpanelSDKPINVOKE.Mixpanel_register_properties(swigCPtr, Value.getCPtr(properties));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool register_once(string key, Value value) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_register_once(swigCPtr, key, Value.getCPtr(value));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool register_once_properties(Value properties) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_register_once_properties(swigCPtr, Value.getCPtr(properties));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool unregister(string key) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_unregister(swigCPtr, key);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool unregister_properties(Value properties) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_unregister_properties(swigCPtr, Value.getCPtr(properties));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Value get_super_properties() {
    Value ret = new Value(MixpanelSDKPINVOKE.Mixpanel_get_super_properties(swigCPtr), true);
    return ret;
  }

  public void clear_super_properties() {
    MixpanelSDKPINVOKE.Mixpanel_clear_super_properties(swigCPtr);
  }

  public bool start_timed_event(string event_name) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_start_timed_event(swigCPtr, event_name);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool start_timed_event_once(string event_name) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_start_timed_event_once(swigCPtr, event_name);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool clear_timed_event(string event_name) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_clear_timed_event(swigCPtr, event_name);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear_timed_events() {
    MixpanelSDKPINVOKE.Mixpanel_clear_timed_events(swigCPtr);
  }

  public void reset() {
    MixpanelSDKPINVOKE.Mixpanel_reset(swigCPtr);
  }

  public void track(string arg0, Value properties) {
    MixpanelSDKPINVOKE.Mixpanel_track__SWIG_0(swigCPtr, arg0, Value.getCPtr(properties));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void track(string arg0) {
    MixpanelSDKPINVOKE.Mixpanel_track__SWIG_1(swigCPtr, arg0);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool has_tracked_integration() {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_has_tracked_integration(swigCPtr);
    return ret;
  }

  public void set_tracked_integration() {
    MixpanelSDKPINVOKE.Mixpanel_set_tracked_integration(swigCPtr);
  }

  public bool has_opted_out() {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_has_opted_out(swigCPtr);
    return ret;
  }

  public void opt_out_tracking() {
    MixpanelSDKPINVOKE.Mixpanel_opt_out_tracking(swigCPtr);
  }

  public void opt_in_tracking(string distinct_id, Value properties) {
    MixpanelSDKPINVOKE.Mixpanel_opt_in_tracking__SWIG_0(swigCPtr, distinct_id, Value.getCPtr(properties));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public void opt_in_tracking(string distinct_id) {
    MixpanelSDKPINVOKE.Mixpanel_opt_in_tracking__SWIG_1(swigCPtr, distinct_id);
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
  }

  public class People : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;

    internal People(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }

    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(People obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }

    ~People() {
      Dispose();
    }

    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            MixpanelSDKPINVOKE.delete_Mixpanel_People(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }

    public void set(string property, Value to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set(swigCPtr, property, Value.getCPtr(to));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_once(string property, Value to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_once(swigCPtr, property, Value.getCPtr(to));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_once_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_once_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void unset(string property) {
      MixpanelSDKPINVOKE.Mixpanel_People_unset(swigCPtr, property);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void unset_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_unset_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void increment(string property, Value by) {
      MixpanelSDKPINVOKE.Mixpanel_People_increment(swigCPtr, property, Value.getCPtr(by));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void increment_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_increment_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void append(string list_name, Value value) {
      MixpanelSDKPINVOKE.Mixpanel_People_append(swigCPtr, list_name, Value.getCPtr(value));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void append_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_append_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void union_(string list_name, Value values) {
      MixpanelSDKPINVOKE.Mixpanel_People_union_(swigCPtr, list_name, Value.getCPtr(values));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void union_properties(Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_union_properties(swigCPtr, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void track_charge(double amount, Value properties) {
      MixpanelSDKPINVOKE.Mixpanel_People_track_charge__SWIG_0(swigCPtr, amount, Value.getCPtr(properties));
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void track_charge(double amount) {
      MixpanelSDKPINVOKE.Mixpanel_People_track_charge__SWIG_1(swigCPtr, amount);
    }

    public void clear_charges() {
      MixpanelSDKPINVOKE.Mixpanel_People_clear_charges(swigCPtr);
    }

    public void delete_user() {
      MixpanelSDKPINVOKE.Mixpanel_People_delete_user(swigCPtr);
    }

    public void set_push_id(string token) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_push_id(swigCPtr, token);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_first_name(string to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_first_name(swigCPtr, to);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_last_name(string to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_last_name(swigCPtr, to);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_name(string to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_name(swigCPtr, to);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_email(string to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_email(swigCPtr, to);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

    public void set_phone(string to) {
      MixpanelSDKPINVOKE.Mixpanel_People_set_phone(swigCPtr, to);
      if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    }

  }

  public Mixpanel.People people {
    set {
      MixpanelSDKPINVOKE.Mixpanel_people_set(swigCPtr, Mixpanel.People.getCPtr(value));
    }
    get {
      global::System.IntPtr cPtr = MixpanelSDKPINVOKE.Mixpanel_people_get(swigCPtr);
      Mixpanel.People ret = (cPtr == global::System.IntPtr.Zero) ? null : new Mixpanel.People(cPtr, false);
      return ret;
    }
  }

  public class LogEntry : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;

    internal LogEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }

    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LogEntry obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }

    ~LogEntry() {
      Dispose();
    }

    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            MixpanelSDKPINVOKE.delete_Mixpanel_LogEntry(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }

    public Mixpanel.LogEntry.Level level {
      set {
        MixpanelSDKPINVOKE.Mixpanel_LogEntry_level_set(swigCPtr, (int)value);
      }
      get {
        Mixpanel.LogEntry.Level ret = (Mixpanel.LogEntry.Level)MixpanelSDKPINVOKE.Mixpanel_LogEntry_level_get(swigCPtr);
        return ret;
      }
    }

    public string message {
      set {
        MixpanelSDKPINVOKE.Mixpanel_LogEntry_message_set(swigCPtr, value);
        if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
      }
      get {
        string ret = MixpanelSDKPINVOKE.Mixpanel_LogEntry_message_get(swigCPtr);
        if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      }
    }

    public LogEntry() : this(MixpanelSDKPINVOKE.new_Mixpanel_LogEntry(), true) {
    }

    public enum Level {
      LL_TRACE = 0,
      LL_DEBUG = 1,
      LL_INFO = 2,
      LL_WARNING = 3,
      LL_ERROR = 4,
      LL_NONE = 5
    }

  }

  public void set_minimum_log_level(Mixpanel.LogEntry.Level level) {
    MixpanelSDKPINVOKE.Mixpanel_set_minimum_log_level(swigCPtr, (int)level);
  }

  public bool get_next_log_entry(Mixpanel.LogEntry entry) {
    bool ret = MixpanelSDKPINVOKE.Mixpanel_get_next_log_entry(swigCPtr, Mixpanel.LogEntry.getCPtr(entry));
    if (MixpanelSDKPINVOKE.SWIGPendingException.Pending) throw MixpanelSDKPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string utc_now() {
    string ret = MixpanelSDKPINVOKE.Mixpanel_utc_now();
    return ret;
  }

  public void on_reachability_changed(Mixpanel.NetworkReachability network_reachability) {
    MixpanelSDKPINVOKE.Mixpanel_on_reachability_changed(swigCPtr, (int)network_reachability);
  }

  public void set_maximum_queue_size(uint maximum_size) {
    MixpanelSDKPINVOKE.Mixpanel_set_maximum_queue_size(swigCPtr, maximum_size);
  }

  public void set_flush_interval(uint seconds) {
    MixpanelSDKPINVOKE.Mixpanel_set_flush_interval(swigCPtr, seconds);
  }

  public void flush_queue() {
    MixpanelSDKPINVOKE.Mixpanel_flush_queue(swigCPtr);
  }

  private void SwigDirectorConnect() {
    MixpanelSDKPINVOKE.Mixpanel_director_connect(swigCPtr);
  }
  public enum NetworkReachability {
    NotReachable,
    ReachableViaCarrierDataNetwork,
    ReachableViaLocalAreaNetwork
  }

}

}
